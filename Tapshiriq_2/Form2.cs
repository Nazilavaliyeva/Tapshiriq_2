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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (number % 2 == 0)
            {
                netice = "cut";
            }
            else 
            {
                netice = "tek";
            }
            label1.Text = netice;
        }
    }
}
