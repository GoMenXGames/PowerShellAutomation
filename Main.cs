using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Principal;

namespace PowerShellAutomation
{

    public partial class Main : Form
    {
        PowerShell ps = PowerShell.Create();
        Collection<PSObject> psUsers;
        public PSObject psUser;
        public Collection<PSObject> psGroups;
        Collection<PSObject> psGroupMembers;
        public Collection<PSObject> psOUs;
        public Collection<PSObject> psDomain;

        public Main()
        {
            InitializeComponent();
            Program.Mainform = this;
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            UpdateUserList();
            UpdateOUList();
            UpdateGroupList();
            UpdateAllTextBoxes();
        }

        private void UpdateOUList()
        {
            Cursor = Cursors.WaitCursor;

            //  Код
            ps.AddCommand("Get-ADOrganizationalUnit").AddParameter("Filter", "*");
            psOUs = ps.Invoke<PSObject>();
            ps.Commands.Clear();
            //

            Cursor = Cursors.Default;
        }

        private void UpdateAllTextBoxes()
        {
            Cursor = Cursors.WaitCursor;
            DistinguishedNameListBox.Items.Clear();
            foreach (var psUser in psUsers) {
                if (UsersComboBox.Text == Convert.ToString(psUser.Properties["Name"].Value))
                {
                    //Заполнение всех полей
                    SamAccountNameTextBox.Text = Convert.ToString(psUser.Properties["SamAccountName"].Value);
                    GivenNametextBox.Text = Convert.ToString(psUser.Properties["GivenName"].Value);
                    SurNametextBox.Text = Convert.ToString(psUser.Properties["SurName"].Value);
                    GUIDtextBox.Text = Convert.ToString(psUser.Properties["ObjectGUID"].Value);
                    SIDtextBox.Text = Convert.ToString(psUser.Properties["SID"].Value);
                    DistinguishedNameListBox.Items.AddRange(Convert.ToString(psUser.Properties["DistinguishedName"].Value).Split(','));
                    //Начало сбора инфы про Группы и их участников

                    PullGroups(psUser.Properties["Name"].Value);
                    this.psUser = psUser;


                    break;
                }
                else if (string.IsNullOrEmpty(UsersComboBox.Text)) {
                    break;
                }
            }
            Cursor = Cursors.Default;
        }

        internal void testMessageBox(string text)
        {
            MessageBox.Show(text, "Сообщение");
        }

        public void PullGroups(object value)
        {
            Cursor = Cursors.WaitCursor;
            UpdateGroupList();
            GroupListBox.Items.Clear();
            //Запуск перебора Групп
            foreach (var psGroup in psGroups)
            {
                try
                {
                    ps.AddCommand("Get-ADGroupMember").AddArgument(Convert.ToString(psGroup.Properties["SamAccountName"].Value));
                    psGroupMembers = ps.Invoke<PSObject>();
                    ps.Commands.Clear();
                    foreach (var psSecGroupMember in psGroupMembers)
                    {
                        if (Convert.ToString(psSecGroupMember.Properties["Name"].Value) == Convert.ToString(value))
                        {
                            GroupListBox.Items.Add(Convert.ToString(psGroup.Properties["Name"].Value));
                        }
                    }

                }
                catch (Exception e)
                {
                    GroupListBox.Items.Add(e + " !ОШИБКА! " + Convert.ToString(psGroup.Properties["Name"].Value));
                }

            }
            Cursor = Cursors.Default;
        }

        public void UpdateUserList()
        {
            Cursor = Cursors.WaitCursor;
            UsersComboBox.Items.Clear();
            ps.AddCommand("Get-ADUser").AddParameter("Filter", "*");
            psUsers = ps.Invoke<PSObject>();
            ps.Commands.Clear();
            foreach (var psUser in psUsers)
            {
                string UserText = Convert.ToString(psUser.Properties["Name"].Value);
                UsersComboBox.Items.Add(UserText);
            }
            Cursor = Cursors.Default;
        }

        private void UpdateGroupList()
        {
            ps.AddCommand("Get-ADGroup").AddParameter("Filter", "*");
            Cursor = Cursors.WaitCursor;
            psGroups = ps.Invoke<PSObject>();
            ps.Commands.Clear();
            Cursor = Cursors.Default;
        }

        private void UsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAllTextBoxes();
        }

        private void GroupChangeButton_Click(object sender, EventArgs e)
        {
            if (UsersComboBox.SelectedIndex != -1)
            {
                this.Enabled = false;
                UserGroupConfig GroupConfigF = new UserGroupConfig();
                GroupConfigF.Show();
            }
            else
            {
                MessageBox.Show("Выберете пользователя из выподающего списка.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool isElevated;
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (isElevated == false)
            {
                MessageBox.Show("Запустите программу с помощью специального интерфейса от пользователя с правами администратора.", "Недостаточно прав", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else 
            { 
                bool error = false;
                try
                {
                    string script = "Get-ADUser -Filter *";
                    Collection<PSObject> obj = ps.AddScript(script).Invoke<PSObject>();

                    //MessageBox.Show(script);
                    if (obj.Count == 0) { throw new CommandNotFoundException(); }
                    ps.Commands.Clear();
                }
                catch (CommandNotFoundException)
                {
                    StopIt stopItF = new StopIt();
                    stopItF.Show();
                    MessageBox.Show("Возможно у вас не установлен компонент для работы с ActiveDirectory \nОбратитесь к системному администратору!", "Возникла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                finally
                {
                    if (!(error))
                    {
                        UpdateUserList();
                        UpdateOUList();
                        UpdateGroupList();
                        UpdateAllTextBoxes();
                        Cursor = Cursors.WaitCursor;
                        ps.AddCommand("Get-ADForest");
                        psDomain = ps.Invoke<PSObject>();
                        string text = Environment.UserDomainName;
                        this.Text = "PowerShell GUI " + Program.version + " [" + Environment.UserDomainName + "\\" + Environment.UserName + "]";
                        Cursor = Cursors.Default;
                    }
                    else { Application.Exit(); }
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UserCreateForm UserCreateF = new UserCreateForm();
            UserCreateF.Show();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            string path = @"script.ps1";

            string commandline = "Testing 123 !@##%(*@%/. ТЕСТИРОВАНИЕ символов на наличие ошибок \n" +
                UsersComboBox.Text + "\n" + GivenNametextBox.Text + "\n" + SurNametextBox.Text + "\n" + SamAccountNameTextBox.Text + "\n" + GUIDtextBox.Text + "\n";
            /*
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF32Encoding(true).GetBytes(commandline);
                fs.Write(info, 0, info.Length);
            }
            */
            string[] nameDomain = Convert.ToString(Program.Mainform.psDomain[0].Properties["Name"].Value).Split('.');
            string Path = "OU=" + "$OU" + ",DC=" + Convert.ToString(nameDomain[0]) + ",DC=" + Convert.ToString(nameDomain[1]);
            string psCommand = "Import-Module ActiveDirectory\n" +
                               "$pass = ConvertTo-SecureString " + "$Password" + " -AsPlainText -force\n" +
                               "New-ADUser -Name \"" + "$Name" + "\" -GivenName \"" + "$GivenName" + "\" -Surname \"" + "$Surname" + "\" -SamAccountName \"" + "$SamAccountName" + "\" -UserPrincipalName \"" + "$UserPrincipalName" + "\" -Path \"" + Path + "\" -AccountPassword $pass -Enabled $true";
            MessageBox.Show(psCommand, "Команда воспроизвадимая Powershell");
            StreamWriter stream = new StreamWriter(path, true, Encoding.Default, 10);
            stream.Write(commandline);
            stream.Close();
            stream.Dispose();
        }

        private void UserRemoveButton_Click(object sender, EventArgs e)
        {
            string[] nameDomain = Convert.ToString(Program.Mainform.psDomain[0].Properties["Name"].Value).Split('.');
            
            if (SamAccountNameTextBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Что хотите удалить пользователя с именем " + UsersComboBox.Text, "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        ps.Commands.Clear();
                        ps.AddScript("Import-Module ActiveDirectory\n" + "Remove-ADUser " + SamAccountNameTextBox.Text + " -Confirm:$false").Invoke();
                        ps.Commands.Clear();
                        UpdateUserList();
                        UsersComboBox.Text = "";
                        GivenNametextBox.Text = "";
                        SurNametextBox.Text = "";
                        SamAccountNameTextBox.Text = "";
                        GUIDtextBox.Text = "";
                        SIDtextBox.Text = "";
                        GroupListBox.Items.Clear();
                        DistinguishedNameListBox.Items.Clear();
                        break;
                    case DialogResult.No:

                        break;
                }
            }
            else { MessageBox.Show("Выберите пользователя", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
                
        public void WIP_Message() 
        {
            MessageBox.Show("Данная функция сейчас в разработке.", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool nightmode = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (nightmode == true)
            {
                this.BackColor = Color.White;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                nightmode = false;
            }
            else
            {
                this.BackColor = Color.Black;
                this.label1.ForeColor = Color.White;
                this.label2.ForeColor = Color.White;
                this.label3.ForeColor = Color.White;
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label8.ForeColor = Color.White;
                nightmode = true;
            }
        }
    }


}
