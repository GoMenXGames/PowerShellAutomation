using System;
using System.Windows.Forms;
using System.Management.Automation;
using System.Security;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace PowerShellAutomation
{
    public partial class UserCreateForm : Form
    {
        //Работаем с файликом
        //static string path = @"script.ps1";

        

        public UserCreateForm()
        {
            Program.UserCreateform = this;
            InitializeComponent();
        }

        private void UserCreateForm_Load(object sender, EventArgs e)
        {
            foreach (var psOU in Program.Mainform.psOUs)
            OUComboBox.Items.Add(psOU.Properties["Name"].Value);
        }

        private void UserCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Mainform.Enabled = true;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else 
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] Name = (NameTextBox.Text.Split(' '));
            GivenNameTextBox.Text = Name[0];
            if (Name.Length > 1) { SurnameTextBox.Text = Name[1]; } else { SurnameTextBox.Text = ""; }
            if (Name.Length > 2) { NameTextBox.Text = Name[0] + " " + Name[1]; }
        }

        private void GivenNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] Name = {GivenNameTextBox.Text, SurnameTextBox.Text};
            if (SurnameTextBox.Text != "") { NameTextBox.Text = Name[0] + " " + Name[1]; } else { NameTextBox.Text = Name[0]; }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] Name = { GivenNameTextBox.Text, SurnameTextBox.Text };
            if (SurnameTextBox.Text != "") { NameTextBox.Text = Name[0] + " " + Name[1]; } else { NameTextBox.Text = Name[0]; }
        }

        private void SamAccountNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UserPrincipalNameTextBox.Text = SamAccountNameTextBox.Text + "@" + Program.Mainform.psDomain[0].Properties["Name"].Value;
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || GivenNameTextBox.Text == "" || SamAccountNameTextBox.Text == "" || OUComboBox.Text == "" || UserPrincipalNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Заполните поля!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DialogResult result = MessageBox.Show("Что хотите создать пользователя с именем " + UserPrincipalNameTextBox.Text + "\n в " + OUComboBox.Text, "Вы уверены?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                switch (result)
                {
                    case DialogResult.Yes:
                        ADUserCreate(NameTextBox.Text , GivenNameTextBox.Text, SurnameTextBox.Text, SamAccountNameTextBox.Text , UserPrincipalNameTextBox.Text , OUComboBox.Text, PasswordTextBox.Text);
                        this.Close();
                        Program.Mainform.UpdateUserList();
                        Program.Mainform.UsersComboBox.Text = NameTextBox.Text;
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Cancel:

                        break;
                }

            }
        }

        private void ADUserCreate(string Name, string GivenName, string Surname, string SamAccountName, string UserPrincipalName, string OU, string Password)
        {
            PowerShell ps = PowerShell.Create();
            ps.Commands.Clear();

            string[] nameDomain = Convert.ToString(Program.Mainform.psDomain[0].Properties["Name"].Value).Split('.');

            string Path = "OU=" + OU + ",DC=" + Convert.ToString(nameDomain[0]) + ",DC=" + Convert.ToString(nameDomain[1]);
            
            string psCommand = "Import-Module ActiveDirectory\n" +
                               "$pass = ConvertTo-SecureString " + Password + " -AsPlainText -force\n" +
                               "New-ADUser -Name \"" + Name + "\" -DisplayName \"" + Name + "\" -GivenName \"" + GivenName + "\" -Surname \"" + Surname + "\" -SamAccountName \"" + SamAccountName + "\" -UserPrincipalName \"" + UserPrincipalName + "\" -Path \"" + Path + "\" -AccountPassword $pass -Enabled $true";
            
            ps.AddScript(psCommand).Invoke();

            ps.Commands.Clear();
        }

    }
}
