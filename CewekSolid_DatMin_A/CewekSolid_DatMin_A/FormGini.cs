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
using ExcelDataReader;
using Microsoft.VisualBasic.FileIO;
namespace CewekSolid_DatMin_A
{
    public partial class FormGini : Form
    {
        DataSet dataset;
        int jumlahRow, jumlahColumn;

        List<DataString> listDataset = new List<DataString>();
        List<string> klasifikasi = new List<string>();
        List<string> tipeKelas = new List<string>();
        List<double> gainFeat = new List<double>();

        public FormGini()
        {
            InitializeComponent();
        }

        private void SimpanData()
        {
            for (int i = 0; i < jumlahRow; i++)
            {
                List<string> listDataRow = new List<string>();

                for (int j = 0; j <= jumlahColumn - 1; j++)
                {
                    string value = dataGridViewGini.Rows[i].Cells[j].Value.ToString();
                    if (j != jumlahColumn - 1)
                    {
                        listDataRow.Add(value);
                    }
                    else
                    {
                        klasifikasi.Add(value);
                        if (!tipeKelas.Contains(value))
                        {
                            tipeKelas.Add(value);
                        }
                    }
                }
                DataString objek = new DataString(listDataRow);
                listDataset.Add(objek);
            }
        }

        private double CountGiniParent()
        {
            List<int> tParent = new List<int>();
            foreach (string type in tipeKelas)
            {
                tParent.Add(0);
            }

            for (int i = 0; i < klasifikasi.Count; i++)
            {
                for (int j = 0; j < tipeKelas.Count; j++)
                {
                    if (klasifikasi[i] == tipeKelas[j])
                    {
                        tParent[j]++;
                        break;
                    }
                }
            }

            double giniParent = 1;
            foreach (int i in tParent)
            {
                double value = (double)i / klasifikasi.Count;
                giniParent -= Math.Pow(value, 2);
            }

            return giniParent;
        }

        private void CountGiniFeat(double giniParent)
        {
            for (int i = 0; i < jumlahColumn - 1; i++)
            {
                List<DataDouble> tJumlah = new List<DataDouble>();
                List<string> tipeFeat = new List<string>();

                for (int j = 0; j < jumlahRow; j++)
                {
                    string temp = listDataset[j].Attribute[i];
                    if (!tipeFeat.Contains(temp))
                    {
                        tipeFeat.Add(temp);
                    }
                }

                foreach (string cls in tipeKelas)
                {
                    List<double> temp = new List<double>();
                    foreach (string f in tipeFeat)
                    {
                        temp.Add(0);
                    }
                    DataDouble ft = new DataDouble(temp);
                    tJumlah.Add(ft);
                }

                for (int j = 0; j < jumlahRow; j++)
                {
                    for (int k = 0; k < tipeFeat.Count; k++)
                    {
                        if (listDataset[j].Attribute[i] == tipeFeat[k])
                        {
                            for (int l = 0; l < tipeKelas.Count; l++)
                            {
                                if (klasifikasi[j] == tipeKelas[l])
                                {
                                    tJumlah[l].Attribute[k]++;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }

                List<double> total = new List<double>();
                for (int j = 0; j < tipeFeat.Count; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < tipeKelas.Count; k++)
                    {
                        temp += tJumlah[k].Attribute[j];
                    }
                    total.Add(temp);
                }

                List<double> giniRes = new List<double>();
                for (int j = 0; j < tipeFeat.Count; j++)
                {
                    double gini1 = 1;
                    for (int k = 0; k < tipeKelas.Count; k++)
                    {
                        double value = tJumlah[k].Attribute[j] / total[j];
                        gini1 -= Math.Pow(value, 2);
                    }
                    giniRes.Add(gini1);
                }

                double giniFeat = 0;
                for (int j = 0; j < giniRes.Count; j++)
                {
                    double value = (total[j] / (double)listDataset.Count) * giniRes[j];
                    giniFeat += value;
                }
                listBoxHasil.Items.Add("Gini (feat " + (i + 1) + ") = " + Math.Round(giniFeat, 3));

                double gain = giniParent - giniFeat;
                gainFeat.Add(gain);
                listBoxHasil.Items.Add("Gain (feat " + (i + 1) + ") = " + Math.Round(gain, 3));
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog()
                { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FileStream filestream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(filestream);
                        IExcelDataReader writer = ExcelReaderFactory.CreateCsvReader(filestream);
                        dataset = reader.AsDataSet();
                        dataGridViewGini.DataSource = dataset.Tables[0];
                        buttonGini.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            const string path = "Gini.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path);
            foreach (var item in listBoxHasil.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Programs saved!");
        }

        private void FormGini_Load(object sender, EventArgs e)
        {
            buttonGini.Enabled = false;
        }

        private void buttonGini_Click(object sender, EventArgs e)
        {
            listBoxHasil.Items.Clear();
            jumlahRow = dataGridViewGini.Rows.Count - 1;
            this.jumlahColumn = dataGridViewGini.Columns.Count;

            if (jumlahRow == 0)
            {
                throw new Exception("Harap Masukkan Data Terlebih Dahulu");
            }

            SimpanData();
            listBoxHasil.Items.Add("Gini:");
            double giniParent = CountGiniParent();
            listBoxHasil.Items.Add("Gini (Parent) = " + Math.Round(giniParent, 3));

            CountGiniFeat(giniParent);

            double maxGain = 0;
            int bestSplitFeat = 0;

            for (int i = 0; i < gainFeat.Count; i++)
            {
                if (gainFeat[i] > maxGain)
                {
                    maxGain = gainFeat[i];
                    bestSplitFeat = i;
                }
            }

            listBoxHasil.Items.Add("");
            listBoxHasil.Items.Add("Best split dengan menggunakan Gini ialah: Feat " + (bestSplitFeat + 1) +
                                   " dengan gain = " + Math.Round(gainFeat[bestSplitFeat], 3));
            listBoxHasil.Items.Add("");
        }
    }
}
