using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapshiriq_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string netice = "";

            if (number % 4 == 0 && number % 6 == 0)
            {
                netice = "4 ve 6-ya bolunur";
            }
            else if (number % 4 == 0)
            {
                netice = "4-e bolunur";
            }
            else if (number % 6 == 0)
            {
                netice = "6- ya bolunur";
            }
            else
            {
                MessageBox.Show("Hec birine bolunmur");
            }
            label1.Text = netice;
        }
    }
}


