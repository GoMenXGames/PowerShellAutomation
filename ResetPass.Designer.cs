
namespace PowerShellAutomation
{
    partial class ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPwd1 = new System.Windows.Forms.Label();
            this.textBoxPwd1 = new System.Windows.Forms.TextBox();
            this.labelPwd2 = new System.Windows.Forms.Label();
            this.textBoxPwd2 = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.Name = "labelUser";
            // 
            // textBoxUser
            // 
            resources.ApplyResources(this.textBoxUser, "textBoxUser");
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.TabStop = false;
            // 
            // labelPwd1
            // 
            resources.ApplyResources(this.labelPwd1, "labelPwd1");
            this.labelPwd1.Name = "labelPwd1";
            // 
            // textBoxPwd1
            // 
            resources.ApplyResources(this.textBoxPwd1, "textBoxPwd1");
            this.textBoxPwd1.Name = "textBoxPwd1";
            this.textBoxPwd1.UseSystemPasswordChar = true;
            // 
            // labelPwd2
            // 
            resources.ApplyResources(this.labelPwd2, "labelPwd2");
            this.labelPwd2.Name = "labelPwd2";
            // 
            // textBoxPwd2
            // 
            resources.ApplyResources(this.textBoxPwd2, "textBoxPwd2");
            this.textBoxPwd2.Name = "textBoxPwd2";
            this.textBoxPwd2.UseSystemPasswordChar = true;
            this.textBoxPwd2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPwd2_KeyDown);
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ResetPass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxPwd2);
            this.Controls.Add(this.textBoxPwd1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPwd2);
            this.Controls.Add(this.labelPwd1);
            this.Controls.Add(this.labelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResetPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPass_FormClosing);
            this.Load += new System.EventHandler(this.ResetPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPwd1;
        private System.Windows.Forms.TextBox textBoxPwd1;
        private System.Windows.Forms.Label labelPwd2;
        private System.Windows.Forms.TextBox textBoxPwd2;
        private System.Windows.Forms.Button buttonReset;
    }
}