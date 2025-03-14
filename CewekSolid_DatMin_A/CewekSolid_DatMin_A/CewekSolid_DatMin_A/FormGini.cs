using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;
namespace CewekSolid_DatMin_A
{
    public partial class FormGini : Form
    {
        public FormGini()
        {
            InitializeComponent();
        }
        CSV csv = new CSV();
        CSV csvResult = new CSV(false);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            csv.GetUrlPath(dataGridView1);
            //buttonEucledian.Enabled = true;
            //buttonManhattan.Enabled = true;
            //buttonSupremum.Enabled = true;
        }
    }
}
