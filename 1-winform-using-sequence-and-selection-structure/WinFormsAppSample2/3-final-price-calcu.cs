using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppSample2
{
    public partial class Program3Form : Form
    {
        public Program3Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program2Form f = new Program2Form();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program4Form f = new Program4Form();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double IP,TR;
            if ((txtPrice.Text != "") && (txtTR.Text != ""))
            {
                if ((double.TryParse(txtPrice.Text, out IP)) && (double.TryParse(txtTR.Text, out TR)))
                {
                    double result = Convert.ToDouble(txtPrice.Text) + (Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtTR.Text));
                    lblResult.Text = "The final price of the item with an inital price " + Convert.ToDouble(txtPrice.Text) + " and a sales tax rate " + Convert.ToDouble(txtTR.Text) + " is " + result + ".";
                    txtPrice.Enabled = false;
                    txtTR.Enabled = false;
                    btnClear.Focus();
                }
                else
                    MessageBox.Show("Invalid value! Please enter numbers only", "Warning!");
                if (!(double.TryParse(txtPrice.Text, out IP)))
                {
                    txtPrice.SelectionStart = 0;
                    txtPrice.SelectionLength = txtPrice.TextLength;
                    txtPrice.Focus();
                    return;
                }
                if (!(double.TryParse(txtTR.Text, out TR)))
                {
                    txtTR.SelectionStart = 0;
                    txtTR.SelectionLength = txtTR.TextLength;
                    txtTR.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("All fields are required", "Warning!");
                if (txtPrice.Text == "")
                {
                    txtPrice.Focus();
                    return;
                }
                if (txtTR.Text == "")
                {
                    txtTR.Focus();
                    return;
                }
            }
        }
       

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtTR.Text = "";
            lblResult.Text = "";
            txtPrice.Enabled = true;
            txtTR.Enabled = true;
        }
    }
}
