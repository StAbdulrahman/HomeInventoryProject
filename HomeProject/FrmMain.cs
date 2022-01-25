using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit this application";
            string title = "Exit Applaction";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void treeViewNavgation_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            treeViewNavgation.ExpandAll();

        }
    }
}
