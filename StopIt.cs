using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellAutomation
{
    public partial class StopIt : Form
    {
        public StopIt()
        {
            InitializeComponent();
            Program.stopItForm = this;
        }

        private void StopIt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
