using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppSample2
{
    public partial class Program5Form : Form
    {
        public Program5Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program4Form f = new Program4Form();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hr, pr;
            if ((txtRate.Text != "") && (txtHours.Text != ""))
            {
                if ((double.TryParse(txtRate.Text, out pr)) && (double.TryParse(txtHours.Text, out hr)))
                {
                    double hrs = Convert.ToDouble(txtHours.Text);
                    if (hrs > 40)
                    {
                        double result = hrs * Convert.ToDouble(txtRate.Text) * 1.5;
                        lblResult.Text = "The calculated gross pay is " + result + ".";
                        txtHours.Enabled = false;
                        txtRate.Enabled = false;
                        btnClear.Focus();
                    }
                    else
                    {
                       double result = hrs * Convert.ToDouble(txtRate.Text);
                       lblResult.Text = "The calculated gross pay is " + result + ".";
                       txtHours.Enabled = false;
                       txtRate.Enabled = false;
                       btnClear.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value! Please enter numbers only", "Warning!");
                    if (!(double.TryParse(txtRate.Text, out pr)))
                    {
                        txtRate.SelectionStart = 0;
                        txtRate.SelectionLength = txtRate.TextLength;
                        txtRate.Focus();
                        return;
                    }
                    if (!(double.TryParse(txtHours.Text, out hr)))
                    {
                        txtHours.SelectionStart = 0;
                        txtHours.SelectionLength = txtHours.TextLength;
                        txtHours.Focus();
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Warning!");
                if (txtRate.Text == "")
                {
                   txtRate.Focus();
                   return;
                }
                if (txtHours.Text == "")
                {
                   txtHours.Focus();
                   return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtRate.Text = "";
            lblResult.Text = "";
            txtHours.Enabled = true;
            txtRate.Enabled = true;
        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
