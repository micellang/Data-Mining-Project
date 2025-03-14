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
        
        public static void CalculateEuclidean(CSV csv, DataGridView dataGrid)
        {
            
            string[] columnDataset = new string[] { };// array untuk menyimpan kolom pada dataset

            List<List<Double>> dataBaris = new List<List<Double>>();// list dengan tipe double untuk menyimpan isi suatu baris dataset

            using (var reader = new StreamReader(csv.Path))
            {
                bool rowSatu = true;
                while (!reader.EndOfStream)
                {
                    if (rowSatu==true)
                    {
                        var row = reader.ReadLine();
                        columnDataset = row.Split(csv.GetDelimiters());
                        rowSatu = false;
                    }
                    else
                    {
                        List<Double> listRowSplited = new List<Double>();
                        var row = reader.ReadLine();
                        foreach (string value in row.Split(csv.GetDelimiters()))
                        {
                            listRowSplited.Add(Convert.ToDouble(value));
                        }
                        dataBaris.Add(listRowSplited);
                    }
                }
            }
            //core
            for (int x = 0; x < dataBaris.Count; x++)
            {
                for (int y = x; y < dataBaris.Count; y++)
                {
                    double countED = 0;

                    for (int z = 0; z < columnDataset.Length; z++)
                    {
                        double selisih = Math.Abs(dataBaris[x][z] - dataBaris[y][z]);
                        countED += Math.Pow(selisih, 2);
                    }
                    double hasilED = Math.Sqrt(countED); 
                    dataGrid.Rows[x].Cells[y].Value = hasilED;
                    dataGrid.Rows[y].Cells[x].Value = hasilED;
                }
            }
        }
        public static void CalculateManhattan(CSV csv, DataGridView dataGrid)
        {
            string[] columnDataset = new string[] { };// array untuk menyimpan kolom pada dataset

            List<List<Double>> dataBaris = new List<List<Double>>();// list dengan tipe double untuk menyimpan isi suatu baris dataset

            using (var reader = new StreamReader(csv.Path))
            {
                bool rowSatu = true;
                while (!reader.EndOfStream)
                {
                    if (rowSatu == true)
                    {
                        var row = reader.ReadLine();
                        columnDataset = row.Split(csv.GetDelimiters());
                        rowSatu = false;
                    }
                    else
                    {
                        List<Double> listRowSplited = new List<Double>();
                        var row = reader.ReadLine();
                        foreach (string value in row.Split(csv.GetDelimiters()))
                        {
                            listRowSplited.Add(Convert.ToDouble(value));
                        }
                        dataBaris.Add(listRowSplited);
                    }
                }
            }
            for (int x = 0; x < dataBaris.Count; x++)
            {
                for (int y = x; y < dataBaris.Count; y++)
                {
                    double countMD = 0;
                    for (int z = 0; z < columnDataset.Length; z++)
                    {
                        double selisih = Math.Abs(dataBaris[x][z] - dataBaris[y][z]);
                        countMD += selisih;
                    }
                    dataGrid.Rows[x].Cells[y].Value = countMD;
                    dataGrid.Rows[y].Cells[x].Value = countMD;
                }
            }
           
        }
        public static void CalculateSupremum(CSV csv, DataGridView dataGrid)
        {
            string[] columnDataset = new string[] { };// array untuk menyimpan kolom pada dataset

            List<List<Double>> dataBaris = new List<List<Double>>();// list dengan tipe double untuk menyimpan isi suatu baris dataset

            using (var reader = new StreamReader(csv.Path))
            {
                bool rowSatu = true;
                while (!reader.EndOfStream)
                {
                    if (rowSatu == true)
                    {
                        var row = reader.ReadLine();
                        columnDataset = row.Split(csv.GetDelimiters());
                        rowSatu = false;
                    }
                    else
                    {
                        List<Double> listRowSplited = new List<Double>();
                        var row = reader.ReadLine();
                        foreach (string value in row.Split(csv.GetDelimiters()))
                        {
                            listRowSplited.Add(Convert.ToDouble(value));
                        }
                        dataBaris.Add(listRowSplited);
                    }
                }
            }
            for (int x = 0; x < dataBaris.Count; x++)
            {
                for (int y = x; y < dataBaris.Count; y++)
                {
                    double tempPlusSD = 0;
                    for (int z = 0; z < columnDataset.Length; z++)
                    {
                        double selisih = Math.Abs(dataBaris[x][z] - dataBaris[y][z]);
                        tempPlusSD = Math.Max(tempPlusSD, selisih);
                    }
                    dataGrid.Rows[x].Cells[y].Value = tempPlusSD;
                    dataGrid.Rows[y].Cells[x].Value = tempPlusSD;
                }
            }
        }

        
        
    }
}
