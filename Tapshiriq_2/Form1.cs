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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string netice = "";

            if (number > 0)
            {
                netice = "Musbet";
            }
            else if (number < 0)
            {
                netice = "Menfi";
            }
            else 
            {
                netice = "Sifir";
            }
            label1.Text = netice;
        }
    }
}
