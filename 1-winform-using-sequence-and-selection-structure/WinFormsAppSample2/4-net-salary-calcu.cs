using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppSample2
{
    public partial class Program4Form : Form
    {
        public Program4Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program3Form f = new Program3Form();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program5Form f = new Program5Form();
            f.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double g;
            if (txtGS.Text != "")
            {
                if (double.TryParse(txtGS.Text, out g))
                {
                    double GS = Convert.ToDouble(txtGS.Text);
                    if (GS > 1000)
                    {
                        GS = GS - (GS * 0.10);
                        lblResult.Text = "The calculated net salary is " + GS + ".";
                        txtGS.Enabled = false;
                        btnClear.Focus();
                    }
                    else
                    {
                        GS = GS - (GS * 0.05);
                        lblResult.Text = "The calculated net salary is " + GS + ".";
                        txtGS.Enabled = false;
                        btnClear.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid value! Please enter positive numbers only!", "Warning!");
                    if (!(double.TryParse(txtGS.Text, out g)))
                    {
                        txtGS.SelectionStart = 0;
                        txtGS.SelectionLength = txtGS.TextLength;
                        txtGS.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Warning!");
                if (txtGS.Text == "")
                    txtGS.Focus();
            }
        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGS.Text = "";
            lblResult.Text = "";
            txtGS.Enabled = true;
        }

        private void txtGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
