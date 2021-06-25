
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
            this.UserRemoveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsersComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UsersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(12, 33);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(340, 28);
            this.UsersComboBox.Sorted = true;
            this.UsersComboBox.TabIndex = 0;
            this.UsersComboBox.SelectedIndexChanged += new System.EventHandler(this.UsersComboBox_SelectedIndexChanged);
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GetButton.Location = new System.Drawing.Point(12, 265);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(102, 28);
            this.GetButton.TabIndex = 6;
            this.GetButton.Text = "&Обновить";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // GivenNametextBox
            // 
            this.GivenNametextBox.Enabled = false;
            this.GivenNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GivenNametextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GivenNametextBox.Location = new System.Drawing.Point(12, 88);
            this.GivenNametextBox.Name = "GivenNametextBox";
            this.GivenNametextBox.Size = new System.Drawing.Size(141, 26);
            this.GivenNametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // SurNametextBox
            // 
            this.SurNametextBox.Enabled = false;
            this.SurNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SurNametextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SurNametextBox.Location = new System.Drawing.Point(165, 88);
            this.SurNametextBox.Name = "SurNametextBox";
            this.SurNametextBox.Size = new System.Drawing.Size(187, 26);
            this.SurNametextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(169, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // SamAccountNameTextBox
            // 
            this.SamAccountNameTextBox.Enabled = false;
            this.SamAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SamAccountNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SamAccountNameTextBox.Location = new System.Drawing.Point(12, 141);
            this.SamAccountNameTextBox.Name = "SamAccountNameTextBox";
            this.SamAccountNameTextBox.Size = new System.Drawing.Size(340, 26);
            this.SamAccountNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SamAccountName";
            // 
            // GUIDtextBox
            // 
            this.GUIDtextBox.Enabled = false;
            this.GUIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GUIDtextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GUIDtextBox.Location = new System.Drawing.Point(12, 193);
            this.GUIDtextBox.Name = "GUIDtextBox";
            this.GUIDtextBox.Size = new System.Drawing.Size(340, 20);
            this.GUIDtextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "GUID";
            // 
            // SIDtextBox
            // 
            this.SIDtextBox.Enabled = false;
            this.SIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SIDtextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SIDtextBox.Location = new System.Drawing.Point(12, 239);
            this.SIDtextBox.Name = "SIDtextBox";
            this.SIDtextBox.Size = new System.Drawing.Size(340, 20);
            this.SIDtextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(16, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "SID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выберите плользователя";
            // 
            // GroupListBox
            // 
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.HorizontalScrollbar = true;
            this.GroupListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GroupListBox.Location = new System.Drawing.Point(358, 33);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(302, 95);
            this.GroupListBox.TabIndex = 8;
            // 
            // DistinguishedNameListBox
            // 
            this.DistinguishedNameListBox.FormattingEnabled = true;
            this.DistinguishedNameListBox.HorizontalScrollbar = true;
            this.DistinguishedNameListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DistinguishedNameListBox.Location = new System.Drawing.Point(358, 185);
            this.DistinguishedNameListBox.Name = "DistinguishedNameListBox";
            this.DistinguishedNameListBox.Size = new System.Drawing.Size(302, 108);
            this.DistinguishedNameListBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(358, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Группы безопасности";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(358, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Доп. Информация";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AddUserButton.Location = new System.Drawing.Point(250, 265);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(102, 28);
            this.AddUserButton.TabIndex = 7;
            this.AddUserButton.Text = "Добавить";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // GroupChangeButton
            // 
            this.GroupChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GroupChangeButton.Location = new System.Drawing.Point(362, 131);
            this.GroupChangeButton.Name = "GroupChangeButton";
            this.GroupChangeButton.Size = new System.Drawing.Size(102, 28);
            this.GroupChangeButton.TabIndex = 9;
            this.GroupChangeButton.Text = "&Изменить";
            this.GroupChangeButton.UseVisualStyleBackColor = true;
            this.GroupChangeButton.Click += new System.EventHandler(this.GroupChangeButton_Click);
            // 
            // UserRemoveButton
            // 
            this.UserRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.UserRemoveButton.Location = new System.Drawing.Point(133, 265);
            this.UserRemoveButton.Name = "UserRemoveButton";
            this.UserRemoveButton.Size = new System.Drawing.Size(102, 28);
            this.UserRemoveButton.TabIndex = 7;
            this.UserRemoveButton.Text = "Удалить";
            this.UserRemoveButton.UseVisualStyleBackColor = true;
            this.UserRemoveButton.Click += new System.EventHandler(this.UserRemoveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(636, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 300);
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
            this.Controls.Add(this.UserRemoveButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.UsersComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PowerShell GUI";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox GivenNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurNametextBox;
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
        private System.Windows.Forms.Button UserRemoveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

