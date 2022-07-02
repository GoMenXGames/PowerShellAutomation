using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Globalization;

namespace PowerShellAutomation
{
    public partial class ResetPass : Form
    {
        PowerShell ps = PowerShell.Create();
        string userGivenName;
        string userSurName;
        string userSAM;
        Collection<PSObject> PasswordPolicy;

        public void ChangeLanguage()
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(ResetPass));
                resources.ApplyResources(c, c.Name, new CultureInfo(Program.Mainform.lang));
            }
        }

        public ResetPass()
        {
            Program.ResetPassForm = this;
            
            InitializeComponent();

        }

        private void questionMessageReset(object sender, EventArgs e) {
            DialogResult result;

            if (Program.Mainform.lang == "ru")
            {
                result = MessageBox.Show($"Сбросить у пользователя {textBoxUser.Text} пароль?", "Вы уверены?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            else
            {
                result = MessageBox.Show($"Reset user {textBoxUser.Text} password?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }

            switch (result)
            {

                case DialogResult.Yes:
                    pwdReset();
                    break;
                case DialogResult.No:
                    Program.Mainform.Enabled = true; //Вернуть управление
                    this.Close(); //Закрыть окно сброса
                    break;
                case DialogResult.Cancel:
                    //Просто закрыть окно
                    break;
            }
        }

        public void buttonReset_Click(object sender, EventArgs e)
        {
            int passLength = Int32.Parse(PasswordPolicy[0].Properties["MinPasswordLength"].Value.ToString());
            if (textBoxPwd1.Text != "")
            {
                if (textBoxPwd1.Text == textBoxPwd2.Text) // Проверка соответствия между паролями
                {
                    if (textBoxPwd1.Text.Length >= passLength) // Проверка длинны пароля
                    {
                        if (!textBoxPwd1.Text.Contains('\"')) // Проверка символов пароля
                        {
                            questionMessageReset(sender, e);
                        }
                        else
                        {
                            if (Program.Mainform.lang == "ru")
                            {
                                WarningMessage("Пароль содержит недопустимые символы! \n(Запрещенные символы пароля: \")");
                            }
                            else
                            {
                                WarningMessage("Password contains invalid characters! \n (Forbidden password characters: \")");
                            }
                            
                        }
                    }
                    else
                    {
                        if (Program.Mainform.lang == "ru")
                        {
                            WarningMessage($"Пароль слишком короткий! (Минимальная длинна пароля: {passLength})");
                        }
                        else
                        {
                            WarningMessage($"The password is too short! (Minimum password length: {passLength})");
                        }
                        
                    }
                }
                else
                {
                    if (Program.Mainform.lang == "ru")
                    {
                        WarningMessage("Пароли не совпадают!");
                    }
                    else
                    {
                        WarningMessage("Password mismatch!");
                    }
                    
                }
            }
            else {
                if (Program.Mainform.lang == "ru")
                {
                    WarningMessage("Введите новый пароль!");
                }
                else
                {
                    WarningMessage("Enter a new password!");
                }
                
            }
        }

        private void pwdReset () {
            ps.AddScript("$user = \"" + userSAM + "\"");
            ps.AddScript("$PlainPassword = \"" + textBoxPwd1.Text + "\"");
            ps.AddScript("$SecurePassword = $PlainPassword | ConvertTo-SecureString -AsPlainText -Force"); //Преобразуем пароль в защишённые данные
            ps.AddScript("Set-ADAccountPassword -Identity $user -Reset -NewPassword $SecurePassword"); //
            ps.Invoke();
            checkPSErrors();
            if(ps.HadErrors) { } else
            {
                Program.Mainform.Enabled = true; //Вернуть управление
                this.Close(); //Закрыть окно сброса
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
                    else if (error == "Не удается выполнить команду из-за следующей ошибки: Неверно задано имя папки." || error == "The command cannot be executed due to the following error: Invalid folder name.")
                    {
                        if (Program.Mainform.lang == "ru")
                        {
                            MessageBox.Show("Переустановите программу в другой папке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reinstall the program in a different folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(commands + "\n" + error + ", \n", "Ошибка Powershell [" + i + "]", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void WarningMessage(string textMessage) {
            if (Program.Mainform.lang == "ru")
            {
                MessageBox.Show(textMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(textMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ResetPass));
            foreach (Control c in this.Controls)
            {
                if (c.Name == "$this.Text") {
                    resources.ApplyResources(c, c.Name, new CultureInfo(Program.Mainform.lang));
                }
            }
            if (Program.Mainform.lang == "ru")
            {
                this.Text = "Сброс пароля";
            }
            else
            {
                this.Text = "Reset password";
            }
            userGivenName = Program.Mainform.GivenNametextBox.Text;
            userSurName = Program.Mainform.SurNametextBox.Text;
            userSAM = Program.Mainform.SamAccountNameTextBox.Text;
            if (userGivenName + userSurName != "")
            {
                textBoxUser.Text = userGivenName + " " + userSurName;
            }
            else
            {
                textBoxUser.Text = userSAM;
            }

            PasswordPolicy = ps.AddScript("Get-ADDefaultDomainPasswordPolicy").Invoke();
        }

        private void ResetPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Mainform.Enabled = true;
        }

        private void textBoxPwd2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonReset_Click(sender, e);
            }
        }
    }
}
