using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CewekSolid_DatMin_A
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void proximityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormProximity"];
            if (frm == null)
            {
                FormProximity frmMaster = new FormProximity();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

        }

        

        private void gINIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormGini"];
            if (frm == null)
            {
                FormGini frmMaster = new FormGini();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kMeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormKMeans"];
            if (frm == null)
            {
                FormKMeans frmMaster = new FormKMeans();
                frmMaster.MdiParent = this;
                frmMaster.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
