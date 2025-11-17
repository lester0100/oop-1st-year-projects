using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppSample2
{
    public partial class Program2Form : Form
    {
        public Program2Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program1Form f = new Program1Form();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program3Form f = new Program3Form();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double rad;
            if (txtRadius.Text != "")
            {
                if (double.TryParse(txtRadius.Text, out rad))
                {
                    double c = Convert.ToDouble(txtRadius.Text) * 2 * 3.1416;
                    lblResult.Text = "The circumference of the circle with a radius " + Convert.ToDouble(txtRadius.Text) + " is " + c + " units.";
                    txtRadius.Enabled = false;
                    btnClear.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid value! Please enter positive numbers only!", "Warning!");
                    if (!(double.TryParse(txtRadius.Text, out rad)))
                    {
                        txtRadius.SelectionStart = 0;
                        txtRadius.SelectionLength = txtRadius.TextLength;
                        txtRadius.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Warning!");
                if (txtRadius.Text == "")
                    txtRadius.Focus();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadius.Text = "";
            lblResult.Text = "";
            txtRadius.Enabled = true;
        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
