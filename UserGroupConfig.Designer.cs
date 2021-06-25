
namespace PowerShellAutomation
{
    partial class UserGroupConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGroupConfig));
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.RemoveGroupButton = new System.Windows.Forms.Button();
            this.RefreshGroupButton = new System.Windows.Forms.Button();
            this.GroupsComboBox = new System.Windows.Forms.ComboBox();
            this.GroupCreatorButton = new System.Windows.Forms.Button();
            this.GroupRemoverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupListBox
            // 
            this.GroupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.ItemHeight = 20;
            this.GroupListBox.Location = new System.Drawing.Point(12, 12);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(507, 244);
            this.GroupListBox.TabIndex = 0;
            this.GroupListBox.SelectedIndexChanged += new System.EventHandler(this.GroupListBox_SelectedIndexChanged);
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AddGroupButton.Location = new System.Drawing.Point(140, 296);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(115, 34);
            this.AddGroupButton.TabIndex = 4;
            this.AddGroupButton.Text = "Добавить в";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // RemoveGroupButton
            // 
            this.RemoveGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RemoveGroupButton.Location = new System.Drawing.Point(12, 296);
            this.RemoveGroupButton.Name = "RemoveGroupButton";
            this.RemoveGroupButton.Size = new System.Drawing.Size(122, 34);
            this.RemoveGroupButton.TabIndex = 3;
            this.RemoveGroupButton.Text = "Удалить из";
            this.RemoveGroupButton.UseVisualStyleBackColor = true;
            this.RemoveGroupButton.Click += new System.EventHandler(this.RemoveGroupButton_Click);
            // 
            // RefreshGroupButton
            // 
            this.RefreshGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RefreshGroupButton.Location = new System.Drawing.Point(260, 296);
            this.RefreshGroupButton.Name = "RefreshGroupButton";
            this.RefreshGroupButton.Size = new System.Drawing.Size(10, 34);
            this.RefreshGroupButton.TabIndex = 2;
            this.RefreshGroupButton.Text = "Обновить";
            this.RefreshGroupButton.UseVisualStyleBackColor = true;
            this.RefreshGroupButton.Click += new System.EventHandler(this.RefreshGroupButton_Click);
            // 
            // GroupsComboBox
            // 
            this.GroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GroupsComboBox.FormattingEnabled = true;
            this.GroupsComboBox.Location = new System.Drawing.Point(12, 262);
            this.GroupsComboBox.Name = "GroupsComboBox";
            this.GroupsComboBox.Size = new System.Drawing.Size(507, 28);
            this.GroupsComboBox.TabIndex = 1;
            this.GroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupsComboBox_SelectedIndexChanged);
            // 
            // GroupCreatorButton
            // 
            this.GroupCreatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GroupCreatorButton.Location = new System.Drawing.Point(404, 296);
            this.GroupCreatorButton.Name = "GroupCreatorButton";
            this.GroupCreatorButton.Size = new System.Drawing.Size(115, 34);
            this.GroupCreatorButton.TabIndex = 4;
            this.GroupCreatorButton.Text = "Создать";
            this.GroupCreatorButton.UseVisualStyleBackColor = true;
            this.GroupCreatorButton.Click += new System.EventHandler(this.GroupCreatorButton_Click);
            // 
            // GroupRemoverButton
            // 
            this.GroupRemoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GroupRemoverButton.Location = new System.Drawing.Point(276, 296);
            this.GroupRemoverButton.Name = "GroupRemoverButton";
            this.GroupRemoverButton.Size = new System.Drawing.Size(122, 34);
            this.GroupRemoverButton.TabIndex = 3;
            this.GroupRemoverButton.Text = "Удалить";
            this.GroupRemoverButton.UseVisualStyleBackColor = true;
            this.GroupRemoverButton.Click += new System.EventHandler(this.GroupRemoverButton_Click);
            // 
            // UserGroupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 339);
            this.Controls.Add(this.GroupsComboBox);
            this.Controls.Add(this.RefreshGroupButton);
            this.Controls.Add(this.GroupRemoverButton);
            this.Controls.Add(this.GroupCreatorButton);
            this.Controls.Add(this.RemoveGroupButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.GroupListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserGroupConfig";
            this.Text = "Конфигурация групп безопасности пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.GroupConfigForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Button RemoveGroupButton;
        private System.Windows.Forms.Button RefreshGroupButton;
        private System.Windows.Forms.ComboBox GroupsComboBox;
        private System.Windows.Forms.Button GroupCreatorButton;
        private System.Windows.Forms.Button GroupRemoverButton;
    }
}