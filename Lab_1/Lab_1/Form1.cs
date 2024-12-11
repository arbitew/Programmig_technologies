using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
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

        private void Form1_MouseHover(object sender, EventArgs e)
            {
            label1.Text = "This text";
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            int a = 1;
            label1.Text = "Click?";
            toolTip1.SetToolTip(label1, "open folder browser");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                tabPage1.Text = "Selected";
            }
            else
            {
                tabPage1.Text = "NothingSelected";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
