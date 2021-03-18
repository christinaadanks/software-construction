using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int a, b;
            char op;
            int c = 0;
            a = Convert.ToInt32(firstNumBox.Text);
            b = Convert.ToInt32(secNumBox.Text);
            op = Convert.ToChar(opBox.Text);

            if (op == '+')
                c = a + b;
            else if (op == '-')
                c = a - b;
            else if ((op == '*') || (op == 'x'))
                c = a * b;

            resultLabel.Text = "The result of " + a.ToString() + " " + op.ToString()
                + " " + b.ToString() + " is: " + c.ToString();
        }

        private void secNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void opBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
