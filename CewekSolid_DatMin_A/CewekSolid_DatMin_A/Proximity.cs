using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CewekSolid_DatMin_A
{
    public class Proximity
    {
        public static void CalculateEuclidean(CSV csv,DataGridView data1)
        {
            //data
            string[] columnArr = new string[] { };

            List<List<Double>> data = new List<List<Double>>();
            

            //read
            using (var reader = new StreamReader(csv.Path))
            {
                bool firstRow = true;
                while (!reader.EndOfStream)
                {
                    if (firstRow)
                    {
                        var row = reader.ReadLine();
                        //columnArr = row.Split(',');
                        columnArr = row.Split(csv.GetDelimiters());
                        firstRow = false;
                    }
                    else
                    {
                        string[] rowData = new string[] { };
                        List<Double> listRowSplited = new List<Double>();

                        var row = reader.ReadLine();

                        //rowData = row.Split(',');
                        rowData = row.Split(csv.GetDelimiters());
                        foreach (string value in rowData)
                        {
                            listRowSplited.Add(Convert.ToDouble(value));
                        }
                        data.Add(listRowSplited);
                    }
                }
            }

            //core
            for (int x = 0; x < data.Count; x++)
            {
                for (int y = x; y < data.Count; y++)
                {
                    double tempPlusED = 0;

                    for (int z = 0; z < columnArr.Length; z++)
                    {
                        double selisih = Math.Abs(data[x][z] - data[y][z]);
                        tempPlusED += Math.Pow(selisih, 2);
                    }
                    double tempSqrt = Math.Sqrt(tempPlusED); //ED
                    data1.Rows[x].Cells[y].Value = tempSqrt;
                    data1.Rows[y].Cells[x].Value = tempSqrt;
                }
            }
        }
        public static void CalculateManhattan(CSV csv, DataGridView data1)
        {
            //data
            string[] columnArr = new string[] { };

            List<List<Double>> data = new List<List<Double>>();
            //read
            using (var reader = new StreamReader(csv.Path))
            {
                bool firstRow = true;
                while (!reader.EndOfStream)
                {
                    if (firstRow)
                    {
                        var row = reader.ReadLine();
                        //columnArr = row.Split(',');
                        columnArr = row.Split(csv.GetDelimiters());
                        firstRow = false;
                    }
                    else
                    {
                        string[] rowData = new string[] { };
                        List<Double> listRowSplited = new List<Double>();

                        var row = reader.ReadLine();
                        //rowData = row.Split(',');
                        rowData = row.Split(csv.GetDelimiters());
                        foreach (string value in rowData)
                        {
                            listRowSplited.Add(Convert.ToDouble(value));
                        }
                        data.Add(listRowSplited);
                    }
                }
            }

            //core
            for (int x = 0; x < data.Count; x++)
            {
                for (int y = x; y < data.Count; y++)
                {
                    double tempPlusMD = 0;
                    for (int z = 0; z < columnArr.Length; z++)
                    {
                        double selisih = Math.Abs(data[x][z] - data[y][z]);
                        tempPlusMD += selisih;
                    }
                    data1.Rows[x].Cells[y].Value = tempPlusMD;
                    data1.Rows[y].Cells[x].Value = tempPlusMD;
                }
            }
           
        }
        public static void CalculateSupremum(CSV csv, DataGridView data1)
        {
            //data
            string[] columnArr = new string[] { };

            List<List<Double>> data = new List<List<Double>>();
            //read
            using (var reader = new StreamReader(csv.Path))
            {
                bool firstRow = true;
                while (!reader.EndOfStream)
                {
                    if (firstRow)
                    {
                        var row = reader.ReadLine();
                        //columnArr = row.Split(',');
                        columnArr = row.Split(csv.GetDelimiters());
                        firstRow = false;
                    }
                    else
                    {
                        string[] rowData = new string[] { };
                        List<Double> listRowSplited = new List<Double>();

                        var row = reader.ReadLine();
                        //rowData = row.Split(',');
                        rowData = row.Split(csv.GetDelimiters());
                        foreach (string value in rowData)
                        {
                            listRowSplited.Add(Convert.ToDouble(value));
                        }
                        data.Add(listRowSplited);
                    }
                }
            }
            
            //core
            for (int x = 0; x < data.Count; x++)
            {
                for (int y = x; y < data.Count; y++)
                {
                    double tempPlusSD = 0;
                    for (int z = 0; z < columnArr.Length; z++)
                    {
                        double selisih = Math.Abs(data[x][z] - data[y][z]);
                        tempPlusSD = Math.Max(tempPlusSD, selisih);
                    }
                    data1.Rows[x].Cells[y].Value = tempPlusSD;
                    data1.Rows[y].Cells[x].Value = tempPlusSD;
                }
            }
        }

        
        
    }
}
