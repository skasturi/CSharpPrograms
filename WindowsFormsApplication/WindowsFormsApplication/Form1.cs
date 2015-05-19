using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int countTo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            progressBar1.PerformStep();
            if (count == countTo)
            {
                MessageBox.Show("Done");
                textBox1.Text = "0";
                progressBar1.Value = 0;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out countTo))
            {
                MessageBox.Show("Please enter a valid number");
                textBox1.Text = "";
            }
            else
            {
                progressBar1.Maximum = countTo;
                progressBar1.Step = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = !progressBar1.Visible;
        }
    }
}
