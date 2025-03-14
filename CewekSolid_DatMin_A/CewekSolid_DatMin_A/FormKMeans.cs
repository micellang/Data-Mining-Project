using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CewekSolid_DatMin_A
{
    public partial class FormKMeans : Form
    {
        public FormKMeans()
        {
            InitializeComponent();
        }
        int k = 3;
        double centerSepalLength1;
        double centerSepalWidth1;
        double centerPetalLength1;
        double centerPetalWidth1;
        double centerSepalLength2;
        double centerSepalWidth2;
        double centerPetalLength2;
        double centerPetalWidth2;
        double centerSepalLength3;
        double centerSepalWidth3;
        double centerPetalLength3;
        double centerPetalWidth3;
        List<double> newCenterSepalLength1 = new List<Double>();
        List<double> newCenterSepalWidth1 = new List<Double>();
        List<double> newCenterPetalLength1 = new List<Double>();
        List<double> newCenterPetalWidth1 = new List<Double>();
        List<double> newCenterSepalLength2 = new List<Double>();
        List<double> newCenterSepalWidth2 = new List<Double>();
        List<double> newCenterPetalLength2 = new List<Double>();
        List<double> newCenterPetalWidth2 = new List<Double>();
        List<double> newCenterSepalLength3 = new List<Double>();
        List<double> newCenterSepalWidth3 = new List<Double>();
        List<double> newCenterPetalLength3 = new List<Double>();
        List<double> newCenterPetalWidth3 = new List<Double>();
        List<int> IdCluster1 = new List<int>();
        List<int> IdCluster2 = new List<int>();
        List<int> IdCluster3 = new List<int>();
        double newCenterPointSepalLength1 = 0;
        double newCenterPointSepalWidth1 = 0;
        double newCenterPointPetalLength1 = 0;
        double newCenterPointPetalWidth1 = 0;
        double newCenterPointSepalLength2 = 0;
        double newCenterPointSepalWidth2 = 0;
        double newCenterPointPetalLength2 = 0;
        double newCenterPointPetalWidth2 = 0;
        double newCenterPointSepalLength3 = 0;
        double newCenterPointSepalWidth3 = 0;
        double newCenterPointPetalLength3 = 0;
        double newCenterPointPetalWidth3 = 0;

        int counter = 0;
        bool repeat = true;
        bool runOnce = false;

        CSV csv = new CSV();
        CSV csvResult = new CSV(false);
        int rowCount;
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            dataGridViewKMeans.DataSource = null;
            dataGridViewKMeans.ColumnCount = 0;
            dataGridView2.DataSource = null;
            dataGridView2.ColumnCount = 0;
            csv.GetUrlPath(dataGridViewKMeans);
            rowCount = dataGridViewKMeans.Rows.Count - 1;
        }

        private double distanceToCenterFunction(double centerSepalLength, double centerSepalWidth,
                                                double centerPetalLength, double centerPetalWidth,
                                                double pointSepalLength, double pointSepalWidth,
                                                double pointPetalLength, double pointPetalWidth)
        {
            var result = Math.Sqrt(Math.Pow(centerSepalLength - pointSepalLength, 2) + Math.Pow(centerSepalWidth - pointSepalWidth, 2) +
                                   Math.Pow(centerPetalLength - pointPetalLength, 2) + Math.Pow(centerPetalWidth - pointPetalWidth, 2));

            return result;
        }

        private void buttonKMeans_Click(object sender, EventArgs e)
        {
            
            NumberFormatInfo formatProvider = new NumberFormatInfo();
            formatProvider.NumberDecimalSeparator = ".";
            formatProvider.NumberGroupSeparator = ",";
            formatProvider.NumberGroupSizes = new int[] { 2 };
            Console.WriteLine("Converted Decimal value...");
            
            int rowC1 = 0;
            int rowC2 = 1;
            int rowC3 = 2;
            centerSepalLength1 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC1].Cells[1].Value.ToString(), formatProvider);
            centerSepalWidth1 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC1].Cells[2].Value.ToString(), formatProvider);
            centerPetalLength1 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC1].Cells[3].Value.ToString(), formatProvider);
            centerPetalWidth1 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC1].Cells[4].Value.ToString(), formatProvider);
            centerSepalLength2 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC2].Cells[1].Value.ToString(), formatProvider);
            centerSepalWidth2 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC2].Cells[2].Value.ToString(), formatProvider);
            centerPetalLength2 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC2].Cells[3].Value.ToString(), formatProvider);
            centerPetalWidth2 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC2].Cells[4].Value.ToString(), formatProvider);
            centerSepalLength3 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC3].Cells[1].Value.ToString(), formatProvider);
            centerSepalWidth3 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC3].Cells[2].Value.ToString(), formatProvider);
            centerPetalLength3 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC3].Cells[3].Value.ToString(), formatProvider);
            centerPetalWidth3 = Convert.ToDouble(dataGridViewKMeans.Rows[rowC3].Cells[4].Value.ToString(), formatProvider);
            int rowLength = Convert.ToInt32(dataGridViewKMeans.Rows.GetRowCount(0)) - 1;

            if (k == 3)
            {
                while (repeat == true)
                {
                    for (int i = 0; i < rowLength; i++)
                    {

                        double pointSL = Convert.ToDouble(dataGridViewKMeans.Rows[i].Cells[1].Value.ToString(), formatProvider);
                        //MessageBox.Show(pointSL.ToString());
                        double pointSW = Convert.ToDouble(dataGridViewKMeans.Rows[i].Cells[2].Value.ToString(), formatProvider);
                        double pointPL = Convert.ToDouble(dataGridViewKMeans.Rows[i].Cells[3].Value.ToString(), formatProvider);
                        double pointPW = Convert.ToDouble(dataGridViewKMeans.Rows[i].Cells[4].Value.ToString(), formatProvider);
                        double distanceToCenter1 = distanceToCenterFunction(centerSepalLength1, centerSepalWidth1, centerPetalLength1, centerPetalWidth1,
                                                                            pointSL, pointSW, pointPL, pointPW);
                        double distanceToCenter2 = distanceToCenterFunction(centerSepalLength2, centerSepalWidth2, centerPetalLength2, centerPetalWidth2,
                                                                            pointSL, pointSW, pointPL, pointPW);
                        double distanceToCenter3 = distanceToCenterFunction(centerSepalLength3, centerSepalWidth3, centerPetalLength3, centerPetalWidth3,
                                                                           pointSL, pointSW, pointPL, pointPW);

                        if (distanceToCenter1 < distanceToCenter2 && distanceToCenter1 < distanceToCenter3)
                        {
                            newCenterSepalLength1.Add(pointSL);
                            newCenterSepalWidth1.Add(pointSW);
                            newCenterPetalLength1.Add(pointPL);
                            newCenterPetalWidth1.Add(pointPW);
                            IdCluster1.Add(i + 1);

                        }
                        else if (distanceToCenter2 < distanceToCenter1 && distanceToCenter2 < distanceToCenter3)
                        {
                            newCenterSepalLength2.Add(pointSL);
                            newCenterSepalWidth2.Add(pointSW);
                            newCenterPetalLength2.Add(pointPL);
                            newCenterPetalWidth2.Add(pointPW);
                            IdCluster2.Add(i + 1);
                        }
                        else if (distanceToCenter3 < distanceToCenter1 && distanceToCenter3 < distanceToCenter2)
                        {
                            newCenterSepalLength3.Add(pointSL);
                            newCenterSepalWidth3.Add(pointSW);
                            newCenterPetalLength3.Add(pointPL);
                            newCenterPetalWidth3.Add(pointPW);
                            IdCluster3.Add(i + 1);
                        }
                        else
                        {
                            MessageBox.Show("Error Code: distanceToCenter");
                        }
                    }
                    for (int i = 0; i < newCenterSepalLength1.Count; i++)
                    {
                        newCenterPointSepalLength1 += newCenterSepalLength1[i];
                    }
                    for (int i = 0; i < newCenterSepalWidth1.Count; i++)
                    {
                        newCenterPointSepalWidth1 += newCenterSepalWidth1[i];
                    }
                    for (int i = 0; i < newCenterPetalLength1.Count; i++)
                    {
                        newCenterPointPetalLength1 += newCenterPetalLength1[i];
                    }
                    for (int i = 0; i < newCenterPetalWidth1.Count; i++)
                    {
                        newCenterPointPetalWidth1 += newCenterPetalWidth1[i];
                    }
                    for (int i = 0; i < newCenterSepalLength2.Count; i++)
                    {
                        newCenterPointSepalLength2 += newCenterSepalLength2[i];
                    }
                    for (int i = 0; i < newCenterSepalWidth2.Count; i++)
                    {
                        newCenterPointSepalWidth2 += newCenterSepalWidth2[i];
                    }
                    for (int i = 0; i < newCenterPetalLength2.Count; i++)
                    {
                        newCenterPointPetalLength2 += newCenterPetalLength2[i];
                    }
                    for (int i = 0; i < newCenterPetalWidth2.Count; i++)
                    {
                        newCenterPointPetalWidth2 += newCenterPetalWidth2[i];
                    }
                    for (int i = 0; i < newCenterSepalLength3.Count; i++)
                    {
                        newCenterPointSepalLength3 += newCenterSepalLength3[i];
                    }
                    for (int i = 0; i < newCenterSepalWidth3.Count; i++)
                    {
                        newCenterPointSepalWidth3 += newCenterSepalWidth3[i];
                    }
                    for (int i = 0; i < newCenterPetalLength3.Count; i++)
                    {
                        newCenterPointPetalLength3 += newCenterPetalLength3[i];
                    }
                    for (int i = 0; i < newCenterPetalWidth3.Count; i++)
                    {
                        newCenterPointPetalWidth3 += newCenterPetalWidth3[i];
                    }
                    newCenterPointSepalLength1 = newCenterPointSepalLength1 / (newCenterSepalLength1.Count == 0 ? 1 : newCenterSepalLength1.Count);
                    newCenterPointSepalWidth1 = newCenterPointSepalWidth1 / (newCenterSepalWidth1.Count == 0 ? 1 : newCenterSepalWidth1.Count);
                    newCenterPointPetalLength1 = newCenterPointPetalLength1 / (newCenterPetalLength1.Count == 0 ? 1 : newCenterPetalLength1.Count);
                    newCenterPointPetalWidth1 = newCenterPointPetalWidth1 / (newCenterPetalWidth1.Count == 0 ? 1 : newCenterPetalWidth1.Count);
                    newCenterPointSepalLength2 = newCenterPointSepalLength2 / (newCenterSepalLength2.Count == 0 ? 1 : newCenterSepalLength2.Count);
                    newCenterPointSepalWidth2 = newCenterPointSepalWidth2 / (newCenterSepalWidth2.Count == 0 ? 1 : newCenterSepalWidth2.Count);
                    newCenterPointPetalLength2 = newCenterPointPetalLength2 / (newCenterPetalLength2.Count == 0 ? 1 : newCenterPetalLength2.Count);
                    newCenterPointPetalWidth2 = newCenterPointPetalWidth2 / (newCenterPetalWidth2.Count == 0 ? 1 : newCenterPetalWidth2.Count);
                    newCenterPointSepalLength3 = newCenterPointSepalLength3 / (newCenterSepalLength3.Count == 0 ? 1 : newCenterSepalLength3.Count);
                    newCenterPointSepalWidth3 = newCenterPointSepalWidth3 / (newCenterSepalWidth3.Count == 0 ? 1 : newCenterSepalWidth3.Count);
                    newCenterPointPetalLength3 = newCenterPointPetalLength3 / (newCenterPetalLength3.Count == 0 ? 1 : newCenterPetalLength3.Count);
                    newCenterPointPetalWidth3 = newCenterPointPetalWidth3 / (newCenterPetalWidth3.Count == 0 ? 1 : newCenterPetalWidth3.Count);

                    centerSepalLength1 = Math.Round(centerSepalLength1, 2);
                    centerSepalWidth1 = Math.Round(centerSepalWidth1, 2);
                    centerPetalLength1 = Math.Round(centerPetalLength1, 2);
                    centerPetalWidth1 = Math.Round(centerPetalWidth1, 2);
                    centerSepalLength2 = Math.Round(centerSepalLength2, 2);
                    centerSepalWidth2 = Math.Round(centerSepalWidth2, 2);
                    centerPetalLength2 = Math.Round(centerPetalLength2, 2);
                    centerPetalWidth2 = Math.Round(centerPetalWidth2, 2);
                    centerSepalLength3 = Math.Round(centerSepalLength3, 2);
                    centerSepalWidth3 = Math.Round(centerSepalWidth3, 2);
                    centerPetalLength3 = Math.Round(centerPetalLength3, 2);
                    centerPetalWidth3 = Math.Round(centerPetalWidth3, 2);
                    newCenterPointSepalLength1 = Math.Round(newCenterPointSepalLength1, 2);
                    newCenterPointSepalWidth1 = Math.Round(newCenterPointSepalWidth1, 2);
                    newCenterPointPetalLength1 = Math.Round(newCenterPointPetalLength1, 2);
                    newCenterPointPetalWidth1 = Math.Round(newCenterPointPetalWidth1, 2);
                    newCenterPointSepalLength2 = Math.Round(newCenterPointSepalLength2, 2);
                    newCenterPointSepalWidth2 = Math.Round(newCenterPointSepalWidth2, 2);
                    newCenterPointPetalLength2 = Math.Round(newCenterPointPetalLength2, 2);
                    newCenterPointPetalWidth2 = Math.Round(newCenterPointPetalWidth2, 2);
                    newCenterPointSepalLength3 = Math.Round(newCenterPointSepalLength3, 2);
                    newCenterPointSepalWidth3 = Math.Round(newCenterPointSepalWidth3, 2);
                    newCenterPointPetalLength3 = Math.Round(newCenterPointPetalLength3, 2);
                    newCenterPointPetalWidth3 = Math.Round(newCenterPointPetalWidth3, 2);

                    if (centerSepalLength1 == newCenterPointSepalLength1 && centerSepalWidth1 == newCenterPointSepalWidth1 &&
                        centerPetalWidth1 == newCenterPointPetalWidth1 && centerPetalLength1 == newCenterPointPetalLength1 &&
                        centerSepalLength2 == newCenterPointSepalLength2 && centerSepalWidth2 == newCenterPointSepalWidth2 &&
                        centerPetalWidth2 == newCenterPointPetalWidth2 && centerPetalLength2 == newCenterPointPetalLength2 &&
                        centerSepalLength3 == newCenterPointSepalLength3 && centerSepalWidth3 == newCenterPointSepalWidth3 &&
                        centerPetalWidth3 == newCenterPointPetalWidth3 && centerPetalLength3 == newCenterPointPetalLength3)
                    {

                        if (runOnce == false)
                        {
                            dataGridView2.Columns.Add("ColumnName", " ");
                            dataGridView2.Columns.Add("ColumnName", dataGridViewKMeans.Columns[1].HeaderText);
                            dataGridView2.Columns.Add("ColumnName", dataGridViewKMeans.Columns[2].HeaderText);
                            dataGridView2.Columns.Add("ColumnName", dataGridViewKMeans.Columns[3].HeaderText);
                            dataGridView2.Columns.Add("ColumnName", dataGridViewKMeans.Columns[4].HeaderText);
                            runOnce = true;
                        }
                        for (int i = 0; i < k; i++)
                        {
                            dataGridView2.DataSource = null;
                            dataGridView2.ColumnCount = 6;
                            dataGridView2.RowCount = 4;
                            dataGridView2.Rows.Add();
                            dataGridView2.Rows[i].Cells[0].Value = "Cluster Center" + " " + (i + 1);
                        }
                        dataGridView2.Rows[0].Cells[1].Value = newCenterPointSepalLength1;
                        dataGridView2.Rows[0].Cells[2].Value = newCenterPointSepalWidth1;
                        dataGridView2.Rows[0].Cells[3].Value = newCenterPointPetalLength1;
                        dataGridView2.Rows[0].Cells[4].Value = newCenterPointPetalWidth1;
                        dataGridView2.Rows[1].Cells[1].Value = newCenterPointSepalLength2;
                        dataGridView2.Rows[1].Cells[2].Value = newCenterPointSepalWidth2;
                        dataGridView2.Rows[1].Cells[3].Value = newCenterPointPetalLength2;
                        dataGridView2.Rows[1].Cells[4].Value = newCenterPointPetalWidth2;
                        dataGridView2.Rows[2].Cells[1].Value = newCenterPointSepalLength3;
                        dataGridView2.Rows[2].Cells[2].Value = newCenterPointSepalWidth3;
                        dataGridView2.Rows[2].Cells[3].Value = newCenterPointPetalLength3;
                        dataGridView2.Rows[2].Cells[4].Value = newCenterPointPetalWidth3;


                        dataGridViewKMeans.DataSource = null;
                        dataGridViewKMeans.ColumnCount = 6;
                        dataGridViewKMeans.RowCount = rowCount;

                        for (int i = 0; i < newCenterSepalLength1.Count; i++)
                        {
                            dataGridViewKMeans.Rows[i].Cells[0].Value = IdCluster1[i];
                            dataGridViewKMeans.Rows[i].Cells[1].Value = newCenterSepalLength1[i];
                            dataGridViewKMeans.Rows[i].Cells[2].Value = newCenterSepalWidth1[i];
                            dataGridViewKMeans.Rows[i].Cells[3].Value = newCenterPetalLength1[i];
                            dataGridViewKMeans.Rows[i].Cells[4].Value = newCenterPetalWidth1[i];
                            dataGridViewKMeans.Rows[i].Cells[5].Value = "Cluster 1";
                        }
                        for (int i = 0; i < newCenterSepalLength2.Count; i++)
                        {
                            dataGridViewKMeans.Rows[i + IdCluster1.Count].Cells[0].Value = IdCluster2[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count].Cells[1].Value = newCenterSepalLength2[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count].Cells[2].Value = newCenterSepalWidth2[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count].Cells[3].Value = newCenterPetalLength2[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count].Cells[4].Value = newCenterPetalWidth2[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count].Cells[5].Value = "Cluster 2";
                        }
                        for (int i = 0; i < newCenterSepalLength3.Count; i++)
                        {
                            dataGridViewKMeans.Rows[i + IdCluster1.Count + IdCluster2.Count].Cells[0].Value = IdCluster3[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count + IdCluster2.Count].Cells[1].Value = newCenterSepalLength3[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count + IdCluster2.Count].Cells[2].Value = newCenterSepalWidth3[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count + IdCluster2.Count].Cells[3].Value = newCenterPetalLength3[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count + IdCluster2.Count].Cells[4].Value = newCenterPetalWidth3[i];
                            dataGridViewKMeans.Rows[i + IdCluster1.Count + IdCluster2.Count].Cells[5].Value = "Cluster 3";
                        }
                        CSV.SaveToCSV(dataGridViewKMeans, "Output K-Means.csv");
                        repeat = false;
                        //newCenterSepalLength1.Clear();
                        //newCenterSepalWidth1.Clear();
                        //newCenterPetalLength1.Clear();
                        //newCenterPetalWidth1.Clear();
                        //newCenterSepalLength2.Clear();
                        //newCenterSepalWidth2.Clear();
                        //newCenterPetalLength2.Clear();
                        //newCenterPetalWidth2.Clear();
                        //newCenterSepalLength3.Clear();
                        //newCenterSepalWidth3.Clear();
                        //newCenterPetalLength3.Clear();
                        //newCenterPetalWidth3.Clear();
                        //IdCluster1.Clear();
                        //IdCluster2.Clear();
                        //IdCluster3.Clear();
                    }
                    else
                    {
                        repeat = true;
                        newCenterSepalLength1.Clear();
                        newCenterSepalWidth1.Clear();
                        newCenterPetalLength1.Clear();
                        newCenterPetalWidth1.Clear();
                        newCenterSepalLength2.Clear();
                        newCenterSepalWidth2.Clear();
                        newCenterPetalLength2.Clear();
                        newCenterPetalWidth2.Clear();
                        newCenterSepalLength3.Clear();
                        newCenterSepalWidth3.Clear();
                        newCenterPetalLength3.Clear();
                        newCenterPetalWidth3.Clear();
                        IdCluster1.Clear();
                        IdCluster2.Clear();
                        IdCluster3.Clear();
                        counter = counter + 1;
                    }
                    centerSepalLength1 = newCenterPointSepalLength1;
                    centerSepalWidth1 = newCenterPointSepalWidth1;
                    centerPetalLength1 = newCenterPointPetalLength1;
                    centerPetalWidth1 = newCenterPointPetalWidth1;
                    centerSepalLength2 = newCenterPointSepalLength2;
                    centerSepalWidth2 = newCenterPointSepalWidth2;
                    centerPetalLength2 = newCenterPointPetalLength2;
                    centerPetalWidth2 = newCenterPointPetalWidth2;
                    centerSepalLength3 = newCenterPointSepalLength3;
                    centerSepalWidth3 = newCenterPointSepalWidth3;
                    centerPetalLength3 = newCenterPointPetalLength3;
                    centerPetalWidth3 = newCenterPointPetalWidth3;
                }


            }
        }

        
    }
}
