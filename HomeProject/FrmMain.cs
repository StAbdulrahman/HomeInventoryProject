using HomeProject.GUI;
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
        private Form currentActiveForm = null;
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
            Form frm = null;

            TreeNode node = e.Node;
            if (node.Name == "NodeMyInventory")
                frm = new FrmMyInventory();
            else if (node.Name == "NodeShoppingItems")
                frm = new FrmShoppingItems();
            else if (node.Name == "NodeUserProfile")
                frm = new FrmUserProfile();
            else if (node.Name == "NodeStatisticsAndCharts")
                frm = new FrmStatisticsAndCharts();

            if(frm != null)
            {
                if (currentActiveForm!= null && currentActiveForm !=frm)
                {
                    currentActiveForm.Close();
                    panelContent.Controls.Remove(currentActiveForm);
                }
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                panelContent.Controls.Add(frm);
                currentActiveForm = frm;
                frm.Show();

            }
            


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            treeViewNavgation.ExpandAll();

        }
    }
}
