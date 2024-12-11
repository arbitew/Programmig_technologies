using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static double G(double x, double y)
        {
            return Math.Sqrt(x)/Math.Log(y);
        }
        /*static double[] rasch(int a, string[] x, string[] y)
        {
            double[] r = new double[a];
            for (int i = 0; i < a; i++)
            {
                r[i] = G(Convert.ToDouble(x[i]), Convert.ToDouble(y[i]));
            }
            return r;
        }*/
    
        static double[,] matr(double x0, double h, int Ny, int Nx)    
        {
        
            double[,] r = new double[Ny + 1, Nx + 1];     
            Random randomq = new Random();        
            r[0, 0] = 0;        
            double sx = x0;        
            for (int i = 1; i <= Ny; i++)        
            {            
                r[i, 0] = x0 + h * (double)i;        
            }       
            for (int i = 1; i <= Nx; i++)        
            {            
                r[0, i] = randomq.NextDouble();        
            }        
            int d = 1;        
            while (d == 1)        
            {           
                d = 0;            
                for (int i = 1; i < Nx; i++)           
                {                
                    if (r[0, i] > r[0, i + 1])                
                    {                   
                        double k = r[0, i + 1];                    
                        r[0, i + 1] = r[0, i];                    
                        r[0, i] = k;                    
                        d = 1;                
                    }            
                }        
            }        
            try            
            {
                for (int i = 1; i <= Ny; i++)                
                {  
                    for (int j = 1; j <= Nx; j++)                   
                    {
                        if (Math.Log(r[0,j]) == 0){
                            r[0, 0] = double.NaN;
                            r[1, 1] = 1.0;
                            return r;
                        }
                        if (r[0, j] <= 0)
                        {
                            r[0, 0] = double.NaN;
                            r[1, 1] = 2.0;
                            return r;
                        }
                        r[i, j] = G(r[i, 0], r[0, j]);
                    }

                }
            }
            catch
            {
            r[0, 0] = double.NaN;
            r[1, 1] = 0.0;
            }
        return r;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            double[,] r = new double[Convert.ToInt32(textBox1.Text) + 1, Convert.ToInt32(textBox4.Text) + 1];
            double[,] r_Err = new double[Convert.ToInt32(textBox1.Text) + 1, Convert.ToInt32(textBox4.Text) + 1];
            string s = "var 14\n";
            string s1 = "\n(x)^(0.5)/log(y)\n";
            int num = 1;
            while (System.IO.File.Exists("G" + Convert.ToString(num) + ".dat"))
            {
                s1 += "G" + Convert.ToString(num) + ".dat\n";
                num++;
            }
            s1 += "G" + Convert.ToString(num) + ".dat\n";
            string path = "Calc.log";
            System.IO.File.SetLastWriteTime(path, DateTime.Now);
            System.IO.File.WriteAllText(path, Convert.ToString(s + System.IO.File.GetLastWriteTime(path) + s1));
            r = matr(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text));
            
            StreamWriter stri = new StreamWriter("G" + Convert.ToString(num) + ".dat");
            if (r[0, 0] == double.NaN)
            {
                StreamWriter ers = new StreamWriter("Errors.log");
                if (r[1, 1] != 0.0)
                {
                    stri.WriteLine("error");
                    stri.Write("y\\x");
                    for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        stri.Write(r[i, 0]);
                    }
                    stri.Write("\n");
                    for (int i = 1; i < Convert.ToInt32(textBox4.Text); i++)
                    {
                        stri.Write(r[0, i]);
                    }
                    ers.WriteLine(s1);
                    ers.WriteLine("error");
                    ers.Write("x\\y");
                    for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        ers.Write(r[i, 0]);
                    }
                    ers.Write("\n");
                    for (int i = 1; i < Convert.ToInt32(textBox4.Text); i++)
                    {
                        ers.Write(r[0, i]);
                    }
                    ers.Close();
                }
                else if (r[1, 1] == 1.0)
                {
                    stri.WriteLine("zero devision");
                    stri.Write("x\\y");
                    for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        stri.Write(r[i, 0]);
                    }
                    stri.Write("\n");
                    for (int i = 1; i < Convert.ToInt32(textBox4.Text); i++)
                    {
                        stri.Write(r[0, i]);
                    }
                    ers.WriteLine(s1);
                    ers.WriteLine("zero devision");
                    ers.Write("x\\y");
                    for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        ers.Write(r[i, 0]);
                    }
                    ers.Write("\n");
                    for (int i = 1; i < Convert.ToInt32(textBox4.Text); i++)
                    {
                        ers.Write(r[0, i]);
                    }
                    ers.Close();

                }
                else if (r[1, 1] == 2.0)
                {
                    stri.WriteLine("y <= 0");
                    stri.Write("x\\y");
                    for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        stri.Write(r[i, 0]);
                    }
                    stri.Write("\n");
                    for (int i = 1; i < Convert.ToInt32(textBox4.Text); i++)
                    {
                        stri.Write(r[0, i]);
                    }
                    ers.WriteLine(s1);
                    ers.WriteLine("y <= 0");
                    ers.Write("x\\y");
                    for (int i = 1; i < Convert.ToInt32(textBox1.Text); i++)
                    {
                        ers.Write(r[i, 0]);
                    }
                    ers.Write("\n");
                    for (int i = 1; i < Convert.ToInt32(textBox4.Text); i++)
                    {
                        ers.Write(r[0, i]);
                    }
                    ers.Close();

                }
            }
            else
            {
                string matri = "";
                for (int i = 0; i < Convert.ToInt32(textBox1.Text) + 1; i++)
                {
                    for (int j = 0; j < Convert.ToInt32(textBox4.Text) + 1; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            matri = matri + "x\\y" + " ";
                        }
                        else
                        {
                            matri = matri + Convert.ToString(r[i, j]) + " ";
                        }
                    }
                    matri = matri + "\n";
                }
                richTextBox2.Text = matri;
                stri.WriteLine(matri); stri.Close();
            }
            //System.IO.File.WriteAllText("G" + Convert.ToString(num + 1) + ".dat", matri);


            /* double[] r = rasch(Convert.ToInt32(textBox1.Text), richTextBox1.Text.Split(' '));
            foreach(double f in r)
            {
                richTextBox2.Text = richTextBox2.Text + " " + f.ToString();
            }*/
        }
    }
}
