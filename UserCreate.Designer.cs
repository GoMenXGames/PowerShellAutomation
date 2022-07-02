
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // GivenNameTextBox
            // 
            resources.ApplyResources(this.GivenNameTextBox, "GivenNameTextBox");
            this.GivenNameTextBox.Name = "GivenNameTextBox";
            this.GivenNameTextBox.TextChanged += new System.EventHandler(this.GivenNameTextBox_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // SurnameTextBox
            // 
            resources.ApplyResources(this.SurnameTextBox, "SurnameTextBox");
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // UserPrincipalNameTextBox
            // 
            resources.ApplyResources(this.UserPrincipalNameTextBox, "UserPrincipalNameTextBox");
            this.UserPrincipalNameTextBox.Name = "UserPrincipalNameTextBox";
            this.UserPrincipalNameTextBox.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // OUComboBox
            // 
            resources.ApplyResources(this.OUComboBox, "OUComboBox");
            this.OUComboBox.FormattingEnabled = true;
            this.OUComboBox.Name = "OUComboBox";
            // 
            // CreateUserButton
            // 
            resources.ApplyResources(this.CreateUserButton, "CreateUserButton");
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            resources.ApplyResources(this.ShowPasswordCheckBox, "ShowPasswordCheckBox");
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // SamAccountNameTextBox
            // 
            resources.ApplyResources(this.SamAccountNameTextBox, "SamAccountNameTextBox");
            this.SamAccountNameTextBox.Name = "SamAccountNameTextBox";
            this.SamAccountNameTextBox.TextChanged += new System.EventHandler(this.SamAccountNameTextBox_TextChanged);
            // 
            // UserCreateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UserCreateForm";
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