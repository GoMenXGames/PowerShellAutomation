
namespace PowerShellAutomation
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.GivenNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SamAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GUIDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SIDtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.DistinguishedNameListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.GroupChangeButton = new System.Windows.Forms.Button();
            this.UserSwitchButton = new System.Windows.Forms.Button();
            this.resetPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.linkLabelLanguage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsersComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.UsersComboBox, "UsersComboBox");
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Sorted = true;
            this.UsersComboBox.SelectedIndexChanged += new System.EventHandler(this.UsersComboBox_SelectedIndexChanged);
            // 
            // GetButton
            // 
            resources.ApplyResources(this.GetButton, "GetButton");
            this.GetButton.Name = "GetButton";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // GivenNametextBox
            // 
            resources.ApplyResources(this.GivenNametextBox, "GivenNametextBox");
            this.GivenNametextBox.Name = "GivenNametextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // SurNametextBox
            // 
            resources.ApplyResources(this.SurNametextBox, "SurNametextBox");
            this.SurNametextBox.Name = "SurNametextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SamAccountNameTextBox
            // 
            resources.ApplyResources(this.SamAccountNameTextBox, "SamAccountNameTextBox");
            this.SamAccountNameTextBox.Name = "SamAccountNameTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // GUIDtextBox
            // 
            resources.ApplyResources(this.GUIDtextBox, "GUIDtextBox");
            this.GUIDtextBox.Name = "GUIDtextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // SIDtextBox
            // 
            resources.ApplyResources(this.SIDtextBox, "SIDtextBox");
            this.SIDtextBox.Name = "SIDtextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // GroupListBox
            // 
            this.GroupListBox.FormattingEnabled = true;
            resources.ApplyResources(this.GroupListBox, "GroupListBox");
            this.GroupListBox.Name = "GroupListBox";
            // 
            // DistinguishedNameListBox
            // 
            this.DistinguishedNameListBox.FormattingEnabled = true;
            resources.ApplyResources(this.DistinguishedNameListBox, "DistinguishedNameListBox");
            this.DistinguishedNameListBox.Name = "DistinguishedNameListBox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // AddUserButton
            // 
            resources.ApplyResources(this.AddUserButton, "AddUserButton");
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // GroupChangeButton
            // 
            resources.ApplyResources(this.GroupChangeButton, "GroupChangeButton");
            this.GroupChangeButton.Name = "GroupChangeButton";
            this.GroupChangeButton.UseVisualStyleBackColor = true;
            this.GroupChangeButton.Click += new System.EventHandler(this.GroupChangeButton_Click);
            // 
            // UserSwitchButton
            // 
            resources.ApplyResources(this.UserSwitchButton, "UserSwitchButton");
            this.UserSwitchButton.Name = "UserSwitchButton";
            this.UserSwitchButton.UseVisualStyleBackColor = true;
            this.UserSwitchButton.Click += new System.EventHandler(this.UserSwitchButton_Click);
            // 
            // resetPass
            // 
            resources.ApplyResources(this.resetPass, "resetPass");
            this.resetPass.Name = "resetPass";
            this.resetPass.UseVisualStyleBackColor = true;
            this.resetPass.Click += new System.EventHandler(this.resetPass_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // linkLabelLanguage
            // 
            resources.ApplyResources(this.linkLabelLanguage, "linkLabelLanguage");
            this.linkLabelLanguage.Name = "linkLabelLanguage";
            this.linkLabelLanguage.TabStop = true;
            this.linkLabelLanguage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLanguage_LinkClicked);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.linkLabelLanguage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resetPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DistinguishedNameListBox);
            this.Controls.Add(this.GroupListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SIDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GUIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SamAccountNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurNametextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GivenNametextBox);
            this.Controls.Add(this.GroupChangeButton);
            this.Controls.Add(this.UserSwitchButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.UsersComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Validated += new System.EventHandler(this.Main_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.Button GetButton;
        public System.Windows.Forms.TextBox GivenNametextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox SurNametextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SamAccountNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GUIDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SIDtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public  System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.ListBox DistinguishedNameListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button GroupChangeButton;
        private System.Windows.Forms.Button UserSwitchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resetPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.LinkLabel linkLabelLanguage;
    }
}

