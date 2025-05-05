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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (bal >= 0 && bal <= 100)
            {
                if (bal >= 0 && bal <= 50)
                {
                    netice = "F";
                }
                else if (bal >= 51 && bal <= 60)
                {
                    netice = "E";
                }
                else if (bal >= 61 && bal <= 70)
                {
                    netice = "D";
                }
                else if (bal >= 71 && bal <= 80)
                {
                    netice = "C";
                }
                else if (bal >= 81 && bal <= 90)
                {
                    netice = "B";
                }
                else if (bal >= 91 && bal <= 100)
                {
                    netice = "A";
                }
               
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            label1.Text = netice;

        }


    }
}

