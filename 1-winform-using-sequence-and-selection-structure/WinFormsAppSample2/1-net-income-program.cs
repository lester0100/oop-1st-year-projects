using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppSample2
{
    public partial class Program1Form : Form
    {
        public Program1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program2Form f = new Program2Form();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtGI.Text = "";
            txtIT.Text = "";
            txtSSS.Text = "";
            txtMI.Text = "";
            lblResult.Text = "";
            txtGI.Enabled = true;
            txtIT.Enabled = true;
            txtSSS.Enabled = true;
            txtMI.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double GI, IT, SSS, MI;
            if ((txtGI.Text != "") && (txtIT.Text != "") && (txtSSS.Text != "") && (txtMI.Text != ""))
            {
                if ((double.TryParse(txtGI.Text, out GI)) && (double.TryParse(txtIT.Text, out IT)) && (Double.TryParse(txtSSS.Text, out SSS)) && (double.TryParse(txtMI.Text, out MI)))
                {
                    double r = Convert.ToDouble(txtGI.Text) - Convert.ToDouble(txtIT.Text) - Convert.ToDouble(txtSSS.Text) - Convert.ToDouble(txtMI.Text);
                    lblResult.Text = " The calculated net income is " + r + ".";
                    txtGI.Enabled = false;
                    txtIT.Enabled = false;
                    txtSSS.Enabled = false;
                    txtMI.Enabled = false;
                    btnClear.Focus();
                }
                else
                    MessageBox.Show("Invalid value! Please enter numbers only", "Warning!");
                if (!(double.TryParse(txtGI.Text, out GI)))
                {
                    txtGI.SelectionStart = 0;
                    txtGI.SelectionLength = txtGI.TextLength;
                    txtGI.Focus();
                    return;
                }
                if (!(double.TryParse(txtIT.Text, out IT)))
                {
                    txtIT.SelectionStart = 0;
                    txtIT.SelectionLength = txtIT.TextLength;
                    txtIT.Focus();
                    return;
                }
                if (!(double.TryParse(txtSSS.Text, out SSS)))
                {
                    txtSSS.SelectionStart = 0;
                    txtSSS.SelectionLength = txtSSS.TextLength;
                    txtSSS.Focus();
                    return;
                }
                if (!(double.TryParse(txtMI.Text, out MI)))
                {
                    txtMI.SelectionStart = 0;
                    txtMI.SelectionLength = txtMI.TextLength;
                    txtMI.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("All fields are required", "Warning!");
                if (txtGI.Text == "")
                {
                    txtGI.Focus();
                    return;
                }
                if (txtIT.Text == "")
                {
                    txtIT.Focus();
                    return;
                }
                if (txtSSS.Text == "")
                {
                    txtSSS.Focus();
                    return;
                }
                if (txtMI.Text == "")
                {
                    txtMI.Focus();
                    return;
                }
            }
        }

        private void txtGI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Program1Form_Load(object sender, EventArgs e)
        {

        }
    }
}
