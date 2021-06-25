
namespace PowerShellAutomation
{
    partial class UserCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GivenNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserPrincipalNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OUComboBox = new System.Windows.Forms.ComboBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SamAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отображаемое имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NameTextBox.Location = new System.Drawing.Point(12, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(343, 26);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя";
            // 
            // GivenNameTextBox
            // 
            this.GivenNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GivenNameTextBox.Location = new System.Drawing.Point(12, 84);
            this.GivenNameTextBox.Name = "GivenNameTextBox";
            this.GivenNameTextBox.Size = new System.Drawing.Size(146, 26);
            this.GivenNameTextBox.TabIndex = 2;
            this.GivenNameTextBox.TextChanged += new System.EventHandler(this.GivenNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(164, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SurnameTextBox.Location = new System.Drawing.Point(164, 84);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(191, 26);
            this.SurnameTextBox.TabIndex = 3;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Полное имя";
            // 
            // UserPrincipalNameTextBox
            // 
            this.UserPrincipalNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.UserPrincipalNameTextBox.Location = new System.Drawing.Point(12, 188);
            this.UserPrincipalNameTextBox.Name = "UserPrincipalNameTextBox";
            this.UserPrincipalNameTextBox.ReadOnly = true;
            this.UserPrincipalNameTextBox.Size = new System.Drawing.Size(343, 26);
            this.UserPrincipalNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 294);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(229, 26);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Подразделение (OU)";
            // 
            // OUComboBox
            // 
            this.OUComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OUComboBox.FormattingEnabled = true;
            this.OUComboBox.Location = new System.Drawing.Point(12, 240);
            this.OUComboBox.Name = "OUComboBox";
            this.OUComboBox.Size = new System.Drawing.Size(344, 28);
            this.OUComboBox.TabIndex = 6;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CreateUserButton.Location = new System.Drawing.Point(0, 340);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(368, 27);
            this.CreateUserButton.TabIndex = 9;
            this.CreateUserButton.Text = "Создать";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(247, 286);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(109, 44);
            this.ShowPasswordCheckBox.TabIndex = 8;
            this.ShowPasswordCheckBox.Text = "Показать\r\nпароль";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Логин";
            // 
            // SamAccountNameTextBox
            // 
            this.SamAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SamAccountNameTextBox.Location = new System.Drawing.Point(12, 136);
            this.SamAccountNameTextBox.Name = "SamAccountNameTextBox";
            this.SamAccountNameTextBox.Size = new System.Drawing.Size(343, 26);
            this.SamAccountNameTextBox.TabIndex = 4;
            this.SamAccountNameTextBox.TextChanged += new System.EventHandler(this.SamAccountNameTextBox_TextChanged);
            // 
            // UserCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 367);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.OUComboBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserPrincipalNameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.GivenNameTextBox);
            this.Controls.Add(this.SamAccountNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserCreateForm";
            this.Text = "Создание пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserCreateForm_FormClosed);
            this.Load += new System.EventHandler(this.UserCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GivenNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserPrincipalNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OUComboBox;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SamAccountNameTextBox;
    }
}