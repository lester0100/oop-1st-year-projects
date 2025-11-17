using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Activity_03_Save_as_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            btnRun.Visible = false;
            progressBar1.Visible = true;
            for (int i = 12; i <= 140 ; i++)
            {
                lblActivity.Location = new Point(12, i);
                progressBar1.Value += 1;
                System.Threading.Thread.Sleep(1);
            }
            for (int j = 317; j >= 140; j-- )
            {
                lbl03.Location = new Point(573, j);
                System.Threading.Thread.Sleep(1);
                progressBar1.Value += 1;
            }
            for (int k = 12; k <= 225; k++)
            {
                lblActivity.Location = new Point(k, 140);
                System.Threading.Thread.Sleep(1);
                progressBar1.Value += 1;
            }
            for (int l = 573; l >= 335; l--)
            {
                lbl03.Location = new Point(l, 140);
                System.Threading.Thread.Sleep(1);
                progressBar1.Value += 1;
            }
            if (progressBar1.Value == 760)
            {
                btnStart.Visible = true;
                btnStart.Enabled = true;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form_Legit f = new Form_Legit();
            f.Show();
            this.Hide();
        }
    }
}
