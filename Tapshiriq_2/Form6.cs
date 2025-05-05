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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double esas = Convert.ToDouble(textBox1.Text);
            double ode = 0;
            double ferq = 0;
            if (esas > 0 && esas < 300)
            {
                ferq = esas * 0.1;
            }
            else if (esas >= 301 && esas <= 500)
            {
                ferq = esas * 0.1;
            }
            else if (esas >= 501 && esas <= 700)
            {
                ferq = esas * 0.15;
            }
            else 
            {
                ferq = esas + 0.2;
            }
            ode = esas - ferq;
            label1.Text = ode.ToString();
        }
    }
}
