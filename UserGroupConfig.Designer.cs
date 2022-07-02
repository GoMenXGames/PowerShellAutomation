
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
            resources.ApplyResources(this.GroupListBox, "GroupListBox");
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.SelectedIndexChanged += new System.EventHandler(this.GroupListBox_SelectedIndexChanged);
            // 
            // AddGroupButton
            // 
            resources.ApplyResources(this.AddGroupButton, "AddGroupButton");
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // RemoveGroupButton
            // 
            resources.ApplyResources(this.RemoveGroupButton, "RemoveGroupButton");
            this.RemoveGroupButton.Name = "RemoveGroupButton";
            this.RemoveGroupButton.UseVisualStyleBackColor = true;
            this.RemoveGroupButton.Click += new System.EventHandler(this.RemoveGroupButton_Click);
            // 
            // RefreshGroupButton
            // 
            resources.ApplyResources(this.RefreshGroupButton, "RefreshGroupButton");
            this.RefreshGroupButton.Name = "RefreshGroupButton";
            this.RefreshGroupButton.UseVisualStyleBackColor = true;
            this.RefreshGroupButton.Click += new System.EventHandler(this.RefreshGroupButton_Click);
            // 
            // GroupsComboBox
            // 
            this.GroupsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GroupsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.GroupsComboBox, "GroupsComboBox");
            this.GroupsComboBox.FormattingEnabled = true;
            this.GroupsComboBox.Name = "GroupsComboBox";
            this.GroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupsComboBox_SelectedIndexChanged);
            // 
            // GroupCreatorButton
            // 
            resources.ApplyResources(this.GroupCreatorButton, "GroupCreatorButton");
            this.GroupCreatorButton.Name = "GroupCreatorButton";
            this.GroupCreatorButton.UseVisualStyleBackColor = true;
            this.GroupCreatorButton.Click += new System.EventHandler(this.GroupCreatorButton_Click);
            // 
            // GroupRemoverButton
            // 
            resources.ApplyResources(this.GroupRemoverButton, "GroupRemoverButton");
            this.GroupRemoverButton.Name = "GroupRemoverButton";
            this.GroupRemoverButton.UseVisualStyleBackColor = true;
            this.GroupRemoverButton.Click += new System.EventHandler(this.GroupRemoverButton_Click);
            // 
            // UserGroupConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupsComboBox);
            this.Controls.Add(this.RefreshGroupButton);
            this.Controls.Add(this.GroupRemoverButton);
            this.Controls.Add(this.GroupCreatorButton);
            this.Controls.Add(this.RemoveGroupButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.GroupListBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserGroupConfig";
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