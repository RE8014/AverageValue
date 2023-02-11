using AverageValue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            bool t1 = int.TryParse(textBox1.Text, out n);
            bool t2 = int.TryParse(textBox2.Text, out n);


            if (t1 && t2 == true)
            {
                int avg;
                int n1;
                int n2;
                int.TryParse(textBox1.Text, out n1);
                int.TryParse(textBox2.Text, out n2);
                avg = (n1 + n2) / 2;
                label6.BackColor = Color.FromArgb(133, 178, 255);
                label6.Text = avg.ToString();
            }
            else
            {
                label6.BackColor = Color.FromArgb(255, 133, 133);
                label6.Text = "Error";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About box = new About();
            box.ShowDialog();

        }
    }
}
