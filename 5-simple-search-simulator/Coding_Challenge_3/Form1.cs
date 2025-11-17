using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding_Challenge_3
{
    public partial class Form1 : Form
    {
        int[] grades = { 90, 100, 1, 0, 24, 87, 50, 41 };
        Label[] lbl1 = new Label[8];
        Label[] lbl2 = new Label[8];
        int i = 0, k = 0;
        string location = "", target = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1[0] = this.label1;
            lbl1[1] = this.label2;
            lbl1[2] = this.label3;
            lbl1[3] = this.label4;
            lbl1[4] = this.label5;
            lbl1[5] = this.label6;
            lbl1[6] = this.label7;
            lbl1[7] = this.label8;
            lbl2[0] = this.label21;
            lbl2[1] = this.label22;
            lbl2[2] = this.label23;
            lbl2[3] = this.label24;
            lbl2[4] = this.label25;
            lbl2[5] = this.label26;
            lbl2[6] = this.label27;
            lbl2[7] = this.label28;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;
            btnDisplay.Visible = false;
            timer1.Enabled = true;
            lblGrade.Visible = true;
            txtGrade.Visible = true;
            txtGrade.Enabled = true;
            txtGrade.Focus();
        }

        private void txtGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                target = txtGrade.Text;
                if (target == "")
                    MessageBox.Show("Field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!(int.TryParse(target, out int a)))
                        Validation();
                    else
                    {
                        if ((Convert.ToInt32(target) < 0) || (Convert.ToInt32(target) > 100))
                            Validation();
                        else
                        {
                            txtGrade.Enabled = false;
                            for (int i = 0; i < grades.Length; i++)
                                lbl2[i].Visible = true;
                            timer2.Enabled = true;
                            for (int j = 0; j < grades.Length; j++)
                            {
                                if (target == grades[j].ToString())
                                    location += + j;
                            }
                            if (location != "")
                                label9.Text = "Result:  " + target + " was found at index/ices " + location + ".";
                            else
                                label9.Text = "Result:  " + target + " does not exist.";
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 8)
            {
                lbl1[i].Text = grades[i].ToString();
                i++;
            }
            else
                timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (k < 8)
            {
                if (Convert.ToInt32(target) == grades[k])
                {
                    lbl2[k].ForeColor = Color.DarkGreen;
                    lbl2[k].Text = "TRUE";
                }
                else
                {
                    lbl2[k].ForeColor = Color.DarkRed;
                    lbl2[k].Text = "FALSE";
                }
                k++;
            }
            else //Enabling the visibility of the objects that holds the result and stopping the timer
            {
                label9.Visible = true;
                timer2.Enabled = false;
            }
        }

        private void Validation()
        {
            MessageBox.Show("Invalid grade!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtGrade.SelectionStart = 0;
            txtGrade.SelectionLength = txtGrade.TextLength;
        }
    }
}
