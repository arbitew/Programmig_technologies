using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
/*chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.Series.Clear();
            chart1.Series.Add("f(x)");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double x = 0;
            const int N = 10;
            for (int i = 0; i < N; i++)
            {
                double y = Math.Cos(x);
                chart1.Series[0].Points.AddXY(x, y);
                x += 0.1;

            }
            chart1.Series.Add("f1(x)");
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            x = 0;
            for (int i = 0; i < N; i++)
            {
                double y = Math.Sin(x);
                chart1.Series[1].Points.AddXY(x, y);
                x += 0.1;

            }

            chart1.Titles.Clear();
            chart1.Titles.Add("That my plot");
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "y";*/

namespace Lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            //59. 13,12,4,11 
            //grid, thickness serif, type, marker presence
            /*chart1.Series.Clear();
            chart1.Series.Add("f(x)");
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            chart1.ChartAreas[0].AxisX.LineDashStyle = ChartDashStyle.Solid;
            chart1.Series[0].MarkerStyle = MarkerStyle.Star4;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double x = 0;
            const int N = 10;
            for (int i = 0; i < N; i++)
            {
                double y = Math.Cos(x);
                chart1.Series[0].Points.AddXY(x, y);
                x += 0.1;

            }
            
            chart1.Titles.Clear();
            chart1.Titles.Add("That my plot");
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "y";*/



            /*chart1.Series.Clear();
            chart1.Series.Add("x");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            double x = 0;
            const int N = 1000;
            for (int i = 0; i < N; i++)
            {
                double y = Math.Cos(x);
                chart1.Series[0].Points.AddXY(x, y);
                x += 0.1;

            }
            chart1.Titles.Clear();
            chart1.Titles.Add("That my plot");
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "y";*/



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int xlen = textBox1.Text.Split('|').Length;
            if (xlen == textBox2.Text.Split('|').Length)
            {
                string[] nums = textBox1.Text.Split('|');
                double[] x = new double[xlen];
                double[] y = new double[xlen];
                try
                {
                    for (int i = 0; i < xlen; i++)
                    {
                        x[i] = Convert.ToDouble(nums[i]);
                    }
                }
                catch
                {
                    MessageBox.Show("Check textbox with x values");
                }
                nums = textBox2.Text.Split('|');
                try
                {
                    for (int i = 0; i < xlen; i++)
                    {
                        y[i] = Convert.ToDouble(nums[i]);
                    }
                }
                catch
                {
                    MessageBox.Show("Check textbox with x values");
                }
                int serCount = Convert.ToInt32(chart1.Series.LongCount());
                chart1.Series.Add("f" + serCount.ToString() + "(x)");
                

                chart1.Series[serCount].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                for (int i = 0; i < xlen; i++)
                {
                    chart1.Series[serCount].Points.AddXY(x[i], y[i]);

                }
                chart1.ChartAreas[0].AxisX.Title = "x";
                chart1.ChartAreas[0].AxisY.Title = "y";
            }
            else
            {
                MessageBox.Show("number x values and number y values are not equal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void FilterBut_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LineWidth = Convert.ToInt32(Axiswidth.Text);
                chart1.ChartAreas[0].AxisY.LineWidth = Convert.ToInt32(Axiswidth.Text);
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (gridCB.SelectedItem.ToString() == "Nogrid")
            {

                chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            }
            if (gridCB.SelectedItem.ToString() == "Solid")
            {

                chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            }
            if (gridCB.SelectedItem.ToString() == "Dash")
            {

                chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            }
            if (gridCB.SelectedItem.ToString() == "Dot")
            {

                chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            }
        }

        private void AxesT_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AxesT_CB.SelectedItem.ToString() == "Solid")
            {

                chart1.ChartAreas[0].AxisX.LineDashStyle = ChartDashStyle.Solid;
                chart1.ChartAreas[0].AxisY.LineDashStyle = ChartDashStyle.Solid;
            }
            if (AxesT_CB.SelectedItem.ToString() == "Dash")
            {

                chart1.ChartAreas[0].AxisX.LineDashStyle = ChartDashStyle.Dash;
                chart1.ChartAreas[0].AxisY.LineDashStyle = ChartDashStyle.Dash;
            }
            if (AxesT_CB.SelectedItem.ToString() == "Dot")
            {

                chart1.ChartAreas[0].AxisX.LineDashStyle = ChartDashStyle.Dot;
                chart1.ChartAreas[0].AxisY.LineDashStyle = ChartDashStyle.Dot;
            }
        }

        private void MarkT_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MarkT_CB.SelectedItem.ToString() == "None")
            {
                chart1.Series[0].MarkerStyle = MarkerStyle.None;
            }
            if (MarkT_CB.SelectedItem.ToString() == "Circle")
            {
                chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            }
            if (MarkT_CB.SelectedItem.ToString() == "Star")
            {
                chart1.Series[0].MarkerStyle = MarkerStyle.Star10;
            }
            if (MarkT_CB.SelectedItem.ToString() == "Cross")
            {
                chart1.Series[0].MarkerStyle = MarkerStyle.Cross;
            }

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            int xlen = TBDiaX.Text.Split('|').Length;
            if (xlen == TBDiaY.Text.Split('|').Length)
            {
                string[] nums = TBDiaX.Text.Split('|');
                string[] x = new string[xlen];
                double[] y = new double[xlen];
                
                    for (int i = 0; i < xlen; i++)
                    {
                        x[i] = nums[i];
                    }
                
                
                nums = TBDiaY.Text.Split('|');
                try
                {
                    for (int i = 0; i < xlen; i++)
                    {
                        y[i] = Convert.ToDouble(nums[i]);
                    }
                }
                catch
                {
                    MessageBox.Show("Check textbox with y values");
                }
                int serCount = Convert.ToInt32(chart2.Series.LongCount());
                chart2.Series.Add("f" + serCount.ToString() + "(x)");/*
                chart2.Series[serCount].XValueType = ChartValueType.String;*/



                chart2.Series[serCount].ChartType = SeriesChartType.Pie;

                for (int i = 0; i < xlen; i++)
                {
                    chart2.Series[serCount].Points.AddXY(x[i], y[i]);
                }
            }
            else
            {
                MessageBox.Show("number x values and number y values are not equal");
            }
        }

        private void TitleB_Click(object sender, EventArgs e)
        {
            chart1.Titles[0].Text = Titlebox.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
        }

        private void surfaceBut_Click(object sender, EventArgs e)
        {
            /*Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 2
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts= false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "gr3d";
            for(int z = 0; z < 10; z++)
            {
                for(int y = 1; y < 10; y++)
                {
                    for(int x = 0; x < 10; x++)
                    {
                        sheet.Cells[x, y + z].Value = x + y + z;
                    }
                }
            }
            */
        }
    }
}
