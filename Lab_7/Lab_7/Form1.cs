using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string rB_Change(string a, string b)
        {
            string x = "";
            string w = "";
            string z = "";
            int d = 0;
            if (b == "X+")
            {
                //string a = richTextBox1.Text;
                for (int i = 1; i < a.Length; i++)
                {
                    if ((Char.IsNumber(a[i])) || a[i] == '-')
                    {
                        while (a[i] != ' ' && a[i] != '\n' && i != (a.Length - 1))
                        {
                            if (d == 0)
                            {
                                x += a[i];
                            }
                            if (d == 1)
                            {
                                w += a[i];
                            }
                            if (d == 2)
                            {
                                z += a[i];
                            }
                            i++;
                        }
                        d++;
                    }
                }
                return "X" + "       " + (Convert.ToDouble(x) + 0.1).ToString() + "\n" + "Theta" + w + "\n" + "Z" + "       " + z + "\n";
            }
            else if(b == "X-")
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if ((Char.IsNumber(a[i])) || a[i] == '-')
                    {
                        while (a[i] != ' ' && a[i] != '\n' && i != (a.Length - 1))
                        {
                            if (d == 0)
                            {
                                x += a[i];
                            }
                            if (d == 1)
                            {
                                w += a[i];
                            }
                            if (d == 2)
                            {
                                z += a[i];
                            }
                            i++;
                        }
                        d++;
                    }
                }
                return "X" + "       " + (Convert.ToDouble(x) - 0.1).ToString() + "\n" + "Theta" + w + "\n" + "Z" + "       " + z + "\n";
            }
            else if (b == "Z+")
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if ((Char.IsNumber(a[i])) || a[i] == '-')
                    {
                        while (a[i] != ' ' && a[i] != '\n' && i != (a.Length - 1))
                        {
                            if (d == 0)
                            {
                                x += a[i];
                            }
                            if (d == 1)
                            {
                                w += a[i];
                            }
                            if (d == 2)
                            {
                                z += a[i];
                            }
                            i++;
                        }
                        d++;
                    }
                }
                return "X" + "       " + x + "\n" + "Theta" + w + "\n" + "Z" + "       " + (Convert.ToDouble(z) + 0.1).ToString() + "\n";
            }
            else if (b == "Z-")
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if ((Char.IsNumber(a[i])) || a[i] == '-')
                    {
                        while (a[i] != ' ' && a[i] != '\n' && i != (a.Length - 1))
                        {
                            if (d == 0)
                            {
                                x += a[i];
                            }
                            if (d == 1)
                            {
                                w += a[i];
                            }
                            if (d == 2)
                            {
                                z += a[i];
                            }
                            i++;
                        }
                        d++;
                    }
                }
                return "X" + "       " + x + "\n" + "Theta" + w + "\n" + "Z" + "       " + (Convert.ToDouble(z) - 0.1).ToString() + "\n";
            }
            else if (b == "CCW")
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if ((Char.IsNumber(a[i])) || a[i] == '-')
                    {
                        while (a[i] != ' ' && a[i] != '\n' && i != (a.Length - 1))
                        {
                            if (d == 0)
                            {
                                x += a[i];
                            }
                            if (d == 1)
                            {
                                w += a[i];
                            }
                            if (d == 2)
                            {
                                z += a[i];
                            }
                            i++;
                        }
                        d++;
                    }
                }
                return "X" + "       " + x + "\n" + "Theta" + (Convert.ToDouble(w) + 0.1).ToString() + "\n" + "Z" + "       " + z + "\n";
            }
            else if (b == "CW")
            {
                for (int i = 1; i < a.Length; i++)
                {
                    if ((Char.IsNumber(a[i])) || a[i] == '-')
                    {
                        while (a[i] != ' ' && a[i] != '\n' && i != (a.Length - 1))
                        {
                            if (d == 0)
                            {
                                x += a[i];
                            }
                            if (d == 1)
                            {
                                w += a[i];
                            }
                            if (d == 2)
                            {
                                z += a[i];
                            }
                            i++;
                        }
                        d++;
                    }
                }
                return "X" + "       " + x + "\n" + "Theta" + (Convert.ToDouble(w) - 0.1).ToString() + "\n" + "Z" + "       " + z + "\n";
            }
            return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void XTZX_Click(object sender, EventArgs e)
        {
            if(XTZX.Text == "XT")
            {
                XTZX.Text = "ZT";
                XplZpl.Text = "Z+";
                XmZm.Text = "Z-";
                CCW_Xpl.Text = "X+";
                CW_Xm.Text = "X-";
            }
            else
            {
                XTZX.Text = "XT";
                XplZpl.Text = "X+";
                XmZm.Text = "X-";
                CCW_Xpl.Text = "CCW";
                CW_Xm.Text = "CW";
            }
        }

        private void XplZpl_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = 
                
                
                 rB_Change(richTextBox1.Text, XplZpl.Text);
        }



        private void XmZm_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = rB_Change(richTextBox1.Text, XmZm.Text);
        }

        

        private void ExitB_Click(object sender, EventArgs e)
        {
                
            DialogResult result = MessageBox.Show(
                "Save?",
                "Exit",              
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                SaveB_Click(sender, e);
            }
            Application.Exit();           
        }

        private void CW_Xm_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = rB_Change(richTextBox1.Text, CW_Xm.Text);
        }
        private void SaveB_Click(object sender, EventArgs e)
        {
            string path;
            int num = 1;
            while (System.IO.File.Exists("G" + Convert.ToString(num) + ".dat"))
            {
                path = "G" + Convert.ToString(num) + ".dat";
                num++;
            }
            path = "G" + Convert.ToString(num) + ".dat";
            System.IO.File.WriteAllText(path, richTextBox1.Text);
        }
        private void CCW_Xpl_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = rB_Change(richTextBox1.Text, CCW_Xpl.Text);
        }

        
        private void StopB_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "X" + "       " + "0" + "\n" + "Theta" + "0" + "\n" + "Z" + "       " + "0" + "\n";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            XplZpl.Location = new Point(hScrollBar1.Value, 42) ;
        }
    }
}
