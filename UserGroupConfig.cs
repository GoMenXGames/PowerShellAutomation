using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management.Automation;

namespace PowerShellAutomation
{
    public partial class UserGroupConfig : Form
    {
        public UserGroupConfig()
        {
            Program.UserGroupConfigForm = this;
            InitializeComponent();
        }

        private void GroupConfigForm_Load(object sender, EventArgs e)
        {
            RefreshGroups();
        }

        private void RefreshGroups()
        {
            Cursor = Cursors.WaitCursor;
            GroupListBox.Items.Clear();
            GroupListBox.Items.AddRange(Program.Mainform.GroupListBox.Items);
            foreach (var group in Program.Mainform.psGroups)
            {
                GroupsComboBox.Items.Add(group.Properties["Name"].Value);
            }
            Cursor = Cursors.Default;
        }

        private void GroupConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Mainform.Enabled = true;
        }

        private void GroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupListBox.SelectedIndex != -1)
            {
                int index = 0;
                foreach (var group in Program.Mainform.psGroups)
                {
                    if (group.Properties["Name"].Value.ToString() == GroupListBox.SelectedItem.ToString())
                    {
                        GroupsComboBox.SelectedIndex = index;
                        break;
                    }
                    index++;
                }
            }
            else { GroupsComboBox.SelectedIndex = -1; }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            if (GroupsComboBox.SelectedIndex != -1)
            {
                psAddGroupMember(GroupsComboBox.SelectedIndex, Program.Mainform.SamAccountNameTextBox.Text);
            }
            else { MessageBox.Show("Выберите группу из выпадающего списка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void psAddGroupMember(int selectedGroupID, string username)
        {
            string psCommand = "Import-Module ActiveDirectory\n"+"Add-ADGroupMember -Identity \"" + Program.Mainform.psGroups[selectedGroupID].Properties["SamAccountName"].Value + "\" -Members " + username + " -Confirm:$false";
            //Program.Mainform.testMessageBox(psCommand);
            PowerShell ps = PowerShell.Create();
            ps.Commands.Clear();
            ps.AddScript(psCommand).Invoke();
            ps.Commands.Clear();
            this.RefreshGroupButton_Click(this, EventArgs.Empty);
        }

        private void RemoveGroupButton_Click(object sender, EventArgs e)
        {
            if (GroupListBox.SelectedIndex != -1)
            {
                psRemoveGroupMember(GroupsComboBox.SelectedIndex, Program.Mainform.SamAccountNameTextBox.Text);
            }
            else {
                MessageBox.Show("Выберете группу безопасности из списка выше.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Remove - ADGroupMember - Identity DocumentReaders - Members DavidChew
        }

        private void psRemoveGroupMember(int selectedGroupID, string username)
        {
            string psCommand = "Import-Module ActiveDirectory\n" + "Remove-ADGroupMember -Identity \"" + Program.Mainform.psGroups[selectedGroupID].Properties["SamAccountName"].Value + "\" -Member " + username + " -Confirm:$false";
            //Program.Mainform.testMessageBox(psCommand);
            PowerShell ps = PowerShell.Create();
            ps.Commands.Clear();
            ps.AddScript(psCommand).Invoke();
            this.RefreshGroupButton_Click(this, EventArgs.Empty);
        }

        private void RefreshGroupButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            GroupsComboBox.Items.Clear();
            GroupListBox.Items.Clear();
            Program.Mainform.PullGroups(Program.Mainform.psUser.Properties["Name"].Value);
            RefreshGroups();
            Cursor = Cursors.Default;
        }

        private void GroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupCreatorButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bool alreadyHas = false;
            if (GroupsComboBox.Text == "")
            {
                MessageBox.Show("Напишите название группы в поле выподающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (GroupsComboBox.Text != "") {
                foreach (var Group in GroupsComboBox.Items) {
                    if (Group.ToString() == GroupsComboBox.Text) {
                        MessageBox.Show("Данная группа безопасности уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        alreadyHas = true;
                        break;
                    }
                }
            }
            if (!alreadyHas)
            {
                DialogResult result = MessageBox.Show("Что хотите создать группу безопасности с именем: " + GroupsComboBox.Text, "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        GroupCreate(GroupsComboBox.Text);
                        break;
                    case DialogResult.No:

                        break;
                }

            }
            Cursor = Cursors.Default;
        }

        private void GroupCreate(string Name)
        {
            string psCommand = "New-ADGroup -Name \"" + Name + "\" -GroupScope 1 -GroupCategory 1";
            PowerShell ps = PowerShell.Create();
            ps.AddScript(psCommand).Invoke();
            //Program.Mainform.testMessageBox(psCommand);
            ps.Commands.Clear();
            this.RefreshGroupButton_Click(this, EventArgs.Empty);
        }

        private void GroupRemoverButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bool Null = false;
            try { string rofl = GroupsComboBox.SelectedItem.ToString(); }
            catch { Null = true; }
            if (Null)
            {
                MessageBox.Show("Выберите группу из выподающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Что хотите удалить группу безопасности с именем: " + GroupsComboBox.SelectedItem.ToString(), "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        GroupRemove(GroupsComboBox.SelectedItem.ToString());
                        GroupsComboBox.Text = "";
                        break;
                    case DialogResult.No:

                        break;
                }

            }
            Cursor = Cursors.Default;
        }

        private void GroupRemove(string Name)
        {
            
            string psCommand = "Remove-ADGroup -Identity \"" + Name + "\" -Confirm:$false";
            PowerShell ps = PowerShell.Create();
            ps.AddScript(psCommand).Invoke();
            //Program.Mainform.testMessageBox(psCommand);
            ps.Commands.Clear();
            this.RefreshGroupButton_Click(this, EventArgs.Empty);
        }
    }
}
