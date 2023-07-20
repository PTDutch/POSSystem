using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPOSSQLServerEFCore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //ControlBox = false;
            WindowState = FormWindowState.Maximized;
        }

        private void opentChilForm(Form f)
        {
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 3;
            f.Top = 3;
            f.Show(); 
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitToolStripButton.PerformClick();
        }

        private void exitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userManagementToolStripButton.PerformClick();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productManagementToolStripButton.PerformClick();
        }

        private void pointOfSaleSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pointOfSaleToolStripButton.PerformClick();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void aboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();

            f.MaximizeBox = false; //ต้องการให้ซ่อน
            f.MinimizeBox = false; //2 อันนี้คือตัวอย่างกำหนดเพิ่มได้เอง

            opentChilForm(f);
        }

        private void userManagementToolStripButton_Click(object sender, EventArgs e)
        {
            UserManagementForm f = new UserManagementForm();
            opentChilForm(f);
        }

        private void productManagementToolStripButton_Click(object sender, EventArgs e)
        {
            ProductManagementForm f = new ProductManagementForm();
            opentChilForm(f);
        }

        private void pointOfSaleToolStripButton_Click(object sender, EventArgs e)
        {
            PointOfSaleForm f = new PointOfSaleForm();
            opentChilForm(f);
        }

        private void logoutToolStripButton_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
