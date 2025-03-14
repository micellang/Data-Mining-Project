using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

namespace CewekSolid_DatMin_A
{
    public partial class FormProximity : Form
    {
        public FormProximity()
        {
            InitializeComponent();
            
        }
        
        CSV csv = new CSV();
        CSV csvResult = new CSV(false);
        int rowCount;
        private void FormProximity_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            csv.GetUrlPath(dataGridViewProx);
            buttonEucledian.Enabled = true;
            buttonManhattan.Enabled = true;
            buttonSupremum.Enabled = true;
            rowCount = dataGridViewProx.Rows.Count - 1;

        }
        List<KeyValuePair<string, double>> listEucledian;
        
        private void buttonEucledian_Click(object sender, EventArgs e)
        {
            dataGridViewProx.DataSource = null; 
            dataGridViewProx.ColumnCount = rowCount;
            dataGridViewProx.RowCount = rowCount;
            Proximity.CalculateEuclidean(csv, dataGridViewProx);
            CSV.SaveToCSV(dataGridViewProx, "Euclidean Distance.csv");
        }

        private void buttonSupremum_Click(object sender, EventArgs e)
        {
            dataGridViewProx.DataSource = null;
            dataGridViewProx.ColumnCount = rowCount;
            dataGridViewProx.RowCount = rowCount;
            Proximity.CalculateSupremum(csv, dataGridViewProx);
            CSV.SaveToCSV(dataGridViewProx, "Supremum Distance.csv");
        }

        private void buttonManhattan_Click(object sender, EventArgs e)
        {
            dataGridViewProx.DataSource = null;
            dataGridViewProx.ColumnCount = rowCount;
            dataGridViewProx.RowCount = rowCount;
            Proximity.CalculateManhattan(csv,dataGridViewProx);
            CSV.SaveToCSV(dataGridViewProx, "Supremum Distance.csv");
        }

        
    }
    
}
