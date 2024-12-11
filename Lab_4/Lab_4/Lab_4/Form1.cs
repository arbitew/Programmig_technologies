using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "D:\\РХТУ\\Studying\\Course 2\\semester 4\\Programming_technologies\\Lab_4\\Lab_4";   
            string[] s = System.IO.Directory.GetDirectories("D:\\РХТУ\\Studying\\Course 2\\semester 4\\Programming_technologies\\Lab_4\\Lab_4");
            foreach (string s2 in s)
            {
                listBox1.Items.AddRange(s2.Split('\\'));
            }//.Substring(label1.Text.Length, s2.Length - label1.Text.Length).
            s = System.IO.Directory.GetFiles("D:\\РХТУ\\Studying\\Course 2\\semester 4\\Programming_technologies\\Lab_4\\Lab_4");
            string s3 = "";
            int flag = 0;
            
            string[] pics = new string[s.Length];
            int kpic = 0;
            foreach (string s2 in s)
            {
                flag = 0;
                int c = 0;
                string extention_ = "";
                for (int i = s2.Length - 1; i > 0; i--)
                {
                    if (s2[i] == '.')
                    {
                        //s2.LastIndexOf('.');
                        c = i;
                        s3 = s2.Substring(c, s2.Length - c);
                        if ((s2.Substring(c, s2.Length - c) == ".png") || (s2.Substring(c, s2.Length - c) == ".jpg") 
                            || (s2.Substring(c, s2.Length - c) == ".tiff") || (s2.Substring(c, s2.Length - c) == ".bmp"))//загнать в массив
                        {
                            flag = 1;
                            if (s2.Substring(c, s2.Length - c) == ".jpg")
                            {
                                listBox2.Items.Add("-http://www.usersite.ru/" + s2);
                                pics[kpic] = s2;
                                kpic++;
                            }
                        }
                        extention_ = s2.Substring(c, s2.Length - c);
                        break;
                    }
                    if (i == 1)
                    {
                        c = s2.Length;
                    }
                }
                s3 = s2.Substring(0, c);
                if (flag == 1)
                {
                    listBox1.Items.Add(s3.Substring(label1.Text.Length, s3.Length - label1.Text.Length) + " image");
                    listBox1.Items.Add("extention of upper file: " + extention_);
                }
                else 
                {
                    listBox1.Items.Add(s3.Substring(label1.Text.Length, s3.Length - label1.Text.Length) + " file");
                    listBox1.Items.Add("extention of upper file: " + extention_);
                }
                if (kpic != 0)
                {
                    for (int i = 0; i < kpic; i++)
                    {
                        listBox2.Items.Add(pics[i]);
                    }
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
