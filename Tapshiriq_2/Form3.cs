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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = " ";
            if (eded%3 == 0 || eded%4 == 0)
            {
                netice = "Bölünür";
            }
            else
            {
                netice = "Bölünmür";
            }
            label1.Text = netice;
        }
    }
}
