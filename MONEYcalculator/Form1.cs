using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONEYcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string duration = textBox1.Text;
            string hours = duration.Substring(0, 2);
            string minuites = duration.Substring(2, 2);
            int hourlypayment = int.Parse(hours) * 40;
            int halfHours = int.Parse(minuites) / 30;
            if (int.Parse(minuites) % 30 > 0)
            {
                halfHours += 1;
            }
            int minuitePayment = halfHours * 20;
            int Payment = hourlypayment + minuitePayment;
            MessageBox.Show("You will be paid £" + Payment);
        }
    }
}
