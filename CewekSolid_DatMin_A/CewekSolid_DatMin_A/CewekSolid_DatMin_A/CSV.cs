using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace CewekSolid_DatMin_A
{
    public class CSV
    {
        string path;
        string filter;
        string[] delimiters;
        bool hasFieldsEnclosedInQuotes;
        bool allowDBNull;
        bool hasTitle;

        public string Path { get => path; set => path = value; }
        public string Filter { get => filter; set => filter = value; }
        public string[] Delimiters { get => delimiters; set => delimiters = value; }
        public bool HasFieldsEnclosedInQuotes { get => hasFieldsEnclosedInQuotes; set => hasFieldsEnclosedInQuotes = value; }
        public bool AllowDBNull { get => allowDBNull; set => allowDBNull = value; }
        public bool HasTitle { get => hasTitle; set => hasTitle = value; }

        public CSV()
        {
            Path = "";
            Filter = "|*.csv";
            Delimiters = new string[] { ";" };
            HasFieldsEnclosedInQuotes = true;
            AllowDBNull = true;
            HasTitle = true;
        }

        public CSV(string pathParam)
        {
            Path = pathParam;
            Filter = "|*.csv";
            Delimiters = new string[] { ";" };
            HasFieldsEnclosedInQuotes = true;
            AllowDBNull = true;
            HasTitle = true;
        }

        public CSV(bool title)
        {
            Path = "";
            Filter = "|*.csv";
            Delimiters = new string[] { ";" };
            HasFieldsEnclosedInQuotes = true;
            AllowDBNull = true;
            HasTitle = title;
        }

        public void SetDelimiters(string delimiter)
        {
            Delimiters = new string[] { delimiter };
        }

        public char GetDelimiters()
        {
            char[] charDelimiters = Delimiters[0].ToCharArray();
            return charDelimiters[0];
        }
    
        public void GetUrlPath(DataGridView dataGridView)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = this.Filter;
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
                DisplayToDataGrid(dataGridView);
            }
        }

        public void DisplayResult(DataGridView dataGridView, string resultPath)
        {
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Replace("file:\\", "") + "/" + resultPath + ".csv";
            Path = path;
            DisplayToDataGrid(dataGridView);
        }

        private DataTable ParseToDataTable()
        {
            DataTable csvData = new DataTable();
            TextFieldParser csvRead = new TextFieldParser(Path);

            csvRead.SetDelimiters(Delimiters);
            csvRead.HasFieldsEnclosedInQuotes = HasFieldsEnclosedInQuotes;

            if (HasTitle)
            {
                string[] kolomFields = csvRead.ReadFields();

                //Store Attribute/Feature Names in csvData.Columns
                foreach (string kolom in kolomFields)
                {
                    DataColumn dataKolom = new DataColumn(kolom);
                    dataKolom.AllowDBNull = AllowDBNull;
                    csvData.Columns.Add(dataKolom);
                }
            }
            else
            {
                csvData.Columns.Add(new DataColumn("Data ke-i hingga Data ke-j"));
                csvData.Columns.Add(new DataColumn("Nilai Proximity"));
            }

            //Store Value of Each Records in csvData.Rows
            while (!csvRead.EndOfData)
            {
                string[] dataField = csvRead.ReadFields();
                for (int i = 0; i < dataField.Length; i++)
                {
                    if (dataField[i] == "")
                    {
                        dataField[i] = null;
                    }
                }
                csvData.Rows.Add(dataField);
            }

            return csvData;
        }

        private void DisplayToDataGrid(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            try
            {
                dataGridView.DataSource = ParseToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveToCSV(DataGridView data1, string outputFile)
        {
            if (data1.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter sw = new StreamWriter(outputFile);

                //write header rows to csv
                for (int i = 0; i <= data1.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        sw.Write("HASIL");
                    }
                    sw.Write(data1.Columns[i].HeaderText);
                }

                sw.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= data1.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        sw.WriteLine();
                    }

                    dr = data1.Rows[j];

                    for (int i = 0; i <= data1.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            sw.Write(";");
                        }
                        try
                        {
                            value = dr.Cells[i].Value.ToString();
                            //replace comma's with spaces
                            value = value.Replace(';', ' ');
                            //replace embedded newlines with spaces
                            value = value.Replace(Environment.NewLine, " ");

                            sw.Write(value);
                        }
                        catch
                        {
                            if (value == null) { break; }
                        }
                    }
                }
                sw.Flush();
                sw.Close();
            }
        }
    }
}
