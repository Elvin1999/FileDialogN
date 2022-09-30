using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in this.Controls)
                {
                    if(item is Label lb)
                    {
                        lb.Font = fontDialog1.Font;
                        lb.ForeColor = fontDialog1.Color;
                    }
                    else if(item is Button bt)
                    {
                        bt.Font = fontDialog1.Font;
                        bt.ForeColor = fontDialog1.Color;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text= folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open=new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt";
            open.FilterIndex = 2;
            if(open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(open.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog save=new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName,richTextBox1.Text);
            }
        }
    }
}
