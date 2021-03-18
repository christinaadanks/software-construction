using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @version 3/12/2021
 * @author Christinaa Danks
 */

namespace HospitalChargesApplication
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BASE_CHARGE = 350m;    // constant value
                decimal days, stayCharge;            // variables

                // Get number of days from TextBoxes
                days = decimal.Parse(daysTextBox.Text);

                // Calculate the charge for hospital stay
                stayCharge = BASE_CHARGE * days;

                // Display total in the format of money, rounded to 2 decimal places
                stayTextBox.Text = stayCharge.ToString("C");
            }
            catch (Exception ex)
            {
                // Display default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void miscButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal medication, surgical, lab, rehab, miscCharge;    // variables

                // Get fees from TextBoxes
                medication = decimal.Parse(medTextBox.Text);
                surgical = decimal.Parse(surgTextBox.Text);
                lab = decimal.Parse(labTextBox.Text);
                rehab = decimal.Parse(physTextBox.Text);

                // Calculate miscellaneous charges
                miscCharge = medication + surgical + lab + rehab;

                // Display total in the format of money, rounded to 2 decimal places
                miscTextBox.Text = miscCharge.ToString("C");
            }

            catch (Exception ex)
            {
                // Display default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BASE_CHARGE = 350m;
                decimal days, medication, surgical, lab, rehab;
                decimal totalCharge;

                // Get other charges from TextBoxes
                days = decimal.Parse(daysTextBox.Text);
                medication = decimal.Parse(medTextBox.Text);
                surgical = decimal.Parse(surgTextBox.Text);
                lab = decimal.Parse(labTextBox.Text);
                rehab = decimal.Parse(physTextBox.Text);

                // Calculate total charges
                totalCharge = (days * BASE_CHARGE) + medication + surgical + lab + rehab;

                // Display total in the format of money, rounded to 2 decimal places
                totalTextBox.Text = totalCharge.ToString("C");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
