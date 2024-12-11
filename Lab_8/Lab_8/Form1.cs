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

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double[,] massF(int N, int M)
        {
            double[,] a = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    try
                    {
                        a[i, j] = 10 * Math.Pow(-1, i + j) + i + j / 10;
                    }
                    catch {
                        a[0, 0] = double.NaN;
                    }
                }
            }
            return a;
        }
        static double[,] polVal(double[,] a, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (a[i, j] < 0)
                    {
                        a[i, j] = double.NaN;
                    }
                }
            }
            return a;
        }
        static double[,] negVal(double[,] a, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (a[i, j] > 0)
                    {
                        a[i, j] = double.NaN;
                    }
                }
            }
            return a;
        }
        
        static double[,] intNum(double[,] a, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((a[i, j].ToString().Split('.')).Length > 1 )
                    {
                        a[i, j] = double.NaN;
                    }
                }
            }
            return a;
        }
        static double[,] nintNum(double[,] a, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((a[i, j].ToString().Split('.')).Length == 1)
                    {
                        a[i, j] = double.NaN;
                    }
                }
            }
            return a;
        }
        static double[,] zeroVal(double[,] a, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (a[i, j] != 0)
                    {
                        a[i, j] = double.NaN;
                    }
                }
            }
            return a;
        }
        private void Form1_Load(object sender, EventArgs e)
        {/*
            dataGridView1.Columns.Add("12", "12");
            dataGridView1.Columns.Add("12", "1212");*/
            button1_Click(sender, e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int N = trackBar1.Value + 1;
            int M = trackBar2.Value + 1;
            double[,] a  = massF(N, M);
            if (double.IsNaN(a[0, 0]))
            {
                MessageBox.Show("Error");
                Application.Exit();
            }
            if (checkBox1.Checked)
            {
                intNum(a, N, M);
            }
            if (checkBox2.Checked)
            {

                nintNum(a, N, M);
            }
            if (checkBox3.Checked)
            {
                polVal(a, N, M);
            }
            if (checkBox4.Checked)
            {
                negVal(a, N, M);
            }
            if (checkBox5.Checked)
            {
                zeroVal(a, N, M);
            }
            for (int i = 0; i < M; i++)
            {
                dataGridView1.Columns.Add("C" + i.ToString(), i.ToString());
            }
            for (int j = 0; j < N; j++)
            {
                dataGridView1.Rows.Add();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (!double.IsNaN(a[i, j]))
                    {
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                    }
                }

            }
            
            
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            button1_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            label3.Text = trackBar2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            label4.Text = trackBar1.Value.ToString();
        }
    }
}
