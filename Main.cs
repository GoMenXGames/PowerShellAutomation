using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace PowerShellAutomation
{

    public partial class Main : Form
    {
        //GET
        public string lang = "ru";
        public string startlang = "en";
        PowerShell ps = PowerShell.Create();
        Collection<PSObject> psUsers;
        public PSObject psUser;
        public Collection<PSObject> psGroups;
        Collection<PSObject> psGroupMembers;
        public Collection<PSObject> psOUs;
        public Collection<PSObject> psDomain;
        bool isElevated = false;
        string userName;
        bool isChecked;
        string path = Environment.CurrentDirectory;

        public void ChangeLanguage()
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));
                resources.ApplyResources(c, c.Name, new CultureInfo(Program.Mainform.lang));
            }
        }

        public Main(string ArgUserName, string ArgLang)
        {
            lang = ArgLang;
            ps.AddScript("Get-ADGroupMember \"domain admins\"");
            psUsers = ps.Invoke<PSObject>();
            ps.Commands.Clear();
            foreach (var chkUser in psUsers)
            {
                if (Convert.ToString(chkUser.Properties["SamAccountName"].Value) == ArgUserName)
                {
                    if (lang == "ru")
                    {
                        MessageBox.Show("Добро пожаловать " + Convert.ToString(chkUser.Properties["Name"].Value));
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + Convert.ToString(chkUser.Properties["Name"].Value));
                    }
                    
                    userName = Convert.ToString(chkUser.Properties["SamAccountName"].Value);
                    isElevated = true;
                    break;
                }
            }
            if (!isElevated)
            {
                if (lang == "ru")
                {
                    MessageBox.Show("У авторизованого пользователя не достаточно прав!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The authorized user does not have enough rights! ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                Application.Exit();
            }
            else
            {

                InitializeComponent();
                Program.Mainform = this;

            }
        }

        public void checkPSErrors()
        {
            if (ps.HadErrors)
            { //Проверяем его на ошибки 
                for (int i = 0; i < ps.Streams.Error.Count; i++)
                {
                    string commands = "";
                    string error = ps.Streams.Error[i].Exception.Message.ToString();

                    for (int j = 0; j < ps.Commands.Commands.Count; j++)
                    {
                        commands += "\n" + ps.Commands.Commands[j].CommandText;
                        string parameters = "";
                        if (ps.Commands.Commands[j].Parameters.Count > 0)
                        {
                            for (int k = 0; k < ps.Commands.Commands[j].Parameters.Count; k++)
                            {
                                parameters = "\n- " + ps.Commands.Commands[j].Parameters[k].Name + ": " + ps.Commands.Commands[j].Parameters[k].Value + ", ";
                            }
                        }
                    }
                    if (error == "The input object cannot be bound to any parameters for the command either because the command does not take pipeline input or the input and its properties do not match any of the parameters that take pipeline input." || error == "Не удается привязать объект ввода к любым параметрам команды, так как команда не принимает входные данные конвейера, либо входные данные и их свойства не совпадают с любыми из параметров, принимающих входные данные конвейера.")
                    {
                        //LUL
                    }
                    else if (error == "Не удается выполнить команду из-за следующей ошибки: Неверно задано имя папки.")
                    {
                        if (lang == "ru")
                        {
                            MessageBox.Show("Переустановите программу в другой папке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reinstall the program in a different folder. ", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(commands + "\n" + error + ", \n" + path, "Ошибка Powershell [" + i + "]", MessageBoxButtons.OK);
                        /*
                        string pathfile = Environment.CurrentDirectory+@"\errors.log";
                        StreamWriter stream = new StreamWriter(pathfile, true, Encoding.Default, 10);
                        string errortext = "Ошибка Powershell[" + i + "]" + commands + "\n" + error + ", \n" + path;
                        stream.Write(errortext);
                        stream.Close();
                        stream.Dispose();
                        */

                    }
                }
            }
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
            Cursor.Current = Cursors.WaitCursor;

            //  Код
            ps.AddCommand("Get-ADOrganizationalUnit").AddParameter("Filter", "*");
            psOUs = ps.Invoke<PSObject>();
            checkPSErrors();
            ps.Commands.Clear();
            //

            Cursor.Current = Cursors.Default;
        }

        private void UpdateAllTextBoxes()
        {
            Cursor.Current = Cursors.WaitCursor;
            DistinguishedNameListBox.Items.Clear();
            foreach (var psUser in psUsers)
            {
                if (UsersComboBox.Text == Convert.ToString(psUser.Properties["Name"].Value))
                {
                    //Заполнение всех полей
                    if (Convert.ToString(psUser.Properties["Enabled"].Value) == "True") { 
                        isChecked = true; panel1.BackColor = Color.OliveDrab;
                        if (lang == "ru")
                        {
                            UserSwitchButton.Text = "Выключть";
                        }
                        else
                        {
                            UserSwitchButton.Text = "Disable";
                        }
                    } 
                    else {
                        isChecked = false; panel1.BackColor = Color.Maroon;
                        if (lang == "ru")
                        {
                            UserSwitchButton.Text = "Включить";
                        }
                        else
                        {
                            UserSwitchButton.Text = "Enable";
                        }
                    };
                    radioButton1.Checked = isChecked;
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
                else if (string.IsNullOrEmpty(UsersComboBox.Text))
                {
                    break;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        internal void testMessageBox(string text)
        {
            
            if (lang == "ru")
            {
                MessageBox.Show(text, "Сообщение");
            }
            else
            {
                MessageBox.Show(text, "Message");
            }
        }

        public void PullGroups(object value)
        {
            Cursor.Current = Cursors.WaitCursor;
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
                    
                    if (lang == "ru")
                    {
                        GroupListBox.Items.Add(e + " !ОШИБКА! " + Convert.ToString(psGroup.Properties["Name"].Value));
                    }
                    else
                    {
                        GroupListBox.Items.Add(e + " !ERROR! " + Convert.ToString(psGroup.Properties["Name"].Value));
                    }
                }

            }
            Cursor.Current = Cursors.Default;
        }

        public void UpdateUserList()
        {
            Cursor.Current = Cursors.WaitCursor;
            UsersComboBox.Items.Clear();
            ps.AddCommand("Get-ADUser").AddParameter("Filter", "*");
            psUsers = ps.Invoke<PSObject>();
            ps.Commands.Clear();
            foreach (var psUser in psUsers)
            {
                string UserText = Convert.ToString(psUser.Properties["Name"].Value);
                UsersComboBox.Items.Add(UserText);
            }
            Cursor.Current = Cursors.Default;
        }

        private void UpdateGroupList()
        {

            Cursor.Current = Cursors.WaitCursor;
            ps.AddCommand("Get-ADGroup").AddParameter("Filter", "*");
            psGroups = ps.Invoke<PSObject>();
            checkPSErrors();
            ps.Commands.Clear();
            Cursor.Current = Cursors.Default;
        }

        private void UsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UpdateAllTextBoxes();
            Cursor.Current = Cursors.Default;
        }

        private void GroupChangeButton_Click(object sender, EventArgs e)
        {
            if (UsersComboBox.SelectedIndex != -1)
            {
                if (SamAccountNameTextBox.Text == "Administrator")
                {

                    if (lang == "ru")
                    {
                        MessageBox.Show("Взаимодействие с пользователем Administrator запрещено!", "Доступ запрещен!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Interaction with the Administrator user is prohibited!", "Access is denied!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                    
                }
                else
                {
                    this.Enabled = false;
                    UserGroupConfig GroupConfigF = new UserGroupConfig();
                    GroupConfigF.Show();
                }
            }
            else
            {
                
                if (lang == "ru")
                {
                    MessageBox.Show("Выберете пользователя из выподающего списка.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Select a user from the dropdown list. "," Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            linkLabelLanguage.Text = lang;
            ChangeLanguage();
            bool error = false;
            try
            {
                string script = "Get-ADUser -Filter *";
                Collection<PSObject> obj = ps.AddScript(script).Invoke<PSObject>();
                checkPSErrors();

                if (obj.Count == 0) { throw new CommandNotFoundException(); }
                ps.Commands.Clear();
            }
            catch (CommandNotFoundException)
            {
                if (lang == "ru")
                {
                    MessageBox.Show("Возможно у вас не установлен компонент для работы с ActiveDirectory \nОбратитесь к системному администратору!", "Возникла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Perhaps you do not have a component for working with ActiveDirectory \nContact your system administrator!", "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                    Cursor.Current = Cursors.WaitCursor;
                    ps.AddCommand("Get-ADForest");
                    psDomain = ps.Invoke<PSObject>();
                    checkPSErrors();
                    string text = Environment.UserDomainName;
                    this.Text = Program.name + " " + Program.version + " [" + Environment.UserDomainName + "\\" + userName + "]";
                    Cursor.Current = Cursors.Default;
                }
                else { Application.Exit(); }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UserCreateForm UserCreateF = new UserCreateForm();
            UserCreateF.Show();
        }


        private void UserSwitchButton_Click(object sender, EventArgs e)
        {
            string[] nameDomain = Convert.ToString(Program.Mainform.psDomain[0].Properties["Name"].Value).Split('.');

            if (SamAccountNameTextBox.Text != "")
            {
                if (SamAccountNameTextBox.Text == "Administrator")
                {

                    if (lang == "ru")
                    {
                        MessageBox.Show("Взаимодействие с пользователем Administrator запрещено!", "Доступ запрещен!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Interaction with the Administrator user is prohibited!", "Access is denied!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        DialogResult result;
                        if (lang == "ru")
                        {
                            result = MessageBox.Show("Что хотите выключить пользователя с именем " + UsersComboBox.Text, "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            result = MessageBox.Show("What do you want to disable a user named " + UsersComboBox.Text, "Are you sure ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        switch (result)
                        {
                            case DialogResult.Yes:
                                ps.Commands.Clear();
                                ps.AddScript("Import-Module ActiveDirectory\n" + "Set-ADUser " + SamAccountNameTextBox.Text + " -Enable:$false").Invoke();
                                checkPSErrors();
                                ps.Commands.Clear();
                                GetButton_Click(sender, e);
                                break;
                            case DialogResult.No:

                                break;
                        }
                    }
                    else {
                        DialogResult result;
                        if (lang == "ru")
                        {
                            result = MessageBox.Show("Что хотите включить пользователя с именем " + UsersComboBox.Text, "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            result = MessageBox.Show("What do you want to enable a user named " + UsersComboBox.Text, "Are you sure ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        switch (result)
                        {
                            case DialogResult.Yes:
                                ps.Commands.Clear();
                                ps.AddScript("Import-Module ActiveDirectory\n" + "Set-ADUser " + SamAccountNameTextBox.Text + " -Enable:$true").Invoke();
                                checkPSErrors();
                                ps.Commands.Clear();
                                GetButton_Click(sender, e);
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                    
                }
            }
            else { 
                
                if (lang == "ru")
                {
                    MessageBox.Show("Выберите пользователя", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

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

        private void resetPass_Click(object sender, EventArgs e)
        {
            if (UsersComboBox.SelectedIndex != -1) {
                if (SamAccountNameTextBox.Text != "Administrator")
                {
                    this.Enabled = false;
                    ResetPass ResetPassForm = new ResetPass();
                    ResetPassForm.Show();
                }
                else
                {
                    if (lang == "ru")
                    {
                        MessageBox.Show("Нельзя сменить пароль у " + SamAccountNameTextBox.Text, "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("You cannot change the password for " + SamAccountNameTextBox.Text, "Oops ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else {
                if (lang == "ru")
                {
                    MessageBox.Show("Выберите пользователя из выпадающего списка!", "Упс..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Select a user from the drop-down list!", "Oops ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabelLanguage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabelLanguage.Text == "ru") {
                linkLabelLanguage.Text = "en";
            }
            else
            {
                linkLabelLanguage.Text = "ru";
            }
            lang = linkLabelLanguage.Text;
            ChangeLanguage();
            GetButton_Click(sender, e);        }

        private void Main_Validated(object sender, EventArgs e)
        {
            ChangeLanguage();
        }
    }
}
