using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private static double F1(double d)
        {
            return Math.Pow(1.2, d);
        }
        private static double F2(double d)
        {
            return Math.Log10(5.0 - ((1.0) / d));
            
        }
        private static double F3(double d)
        {
                return (Math.Exp(d) / Math.Log(5 - d));
        }
        private static double F4(double d)
        {
            double k = 0;
            for(int i = 0; i < 1000000; i++)
            {
                if ((d + Math.Sqrt(i)) != 0)
                {
                    k += (1 / (d + Math.Sqrt(i)));
                }
            }
            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d;
                const int N = 1000;
                Random rnd = new Random();
                double[] a = new double[N];
                double k = 0;
                for (int i = 0; i < N; i++)
                {
                    d = rnd.NextDouble();
                    while ((5.0 - d < 0.0) || (5.0 - d == 1.0) || (d == 0.0) || (5.0 - ((1.0) / d) < 0))
                    {
                        d = rnd.NextDouble();
                    }
                    a[i] = F1(d) + F2(d) + F3(d) + F4(d);
                    
                }
                foreach (double f in a)
                {
                    richTextBox1.Text = richTextBox1.Text + " " + f.ToString()+ '\n';
                    k += f;
                }
                label1.Text = label1.Text + k.ToString();
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
