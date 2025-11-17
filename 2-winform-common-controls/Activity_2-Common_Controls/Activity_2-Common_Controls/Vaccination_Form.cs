using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2_Common_Controls
{
    public partial class frmVac : Form
    {
        public frmVac()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string data = "";
            int FN,LN,Em,Ad,Loc;
            if ((txtFN.Text != "") && (txtLN.Text != ""))
            {
                if ((int.TryParse(txtFN.Text, out FN)) || (int.TryParse(txtLN.Text, out LN)))
                {
                    MessageBox.Show("Invalid data was input.", "Warning!");
                    if (int.TryParse(txtFN.Text, out FN))
                    {
                        txtFN.SelectionStart = 0;
                        txtFN.SelectionLength = txtFN.TextLength;
                        txtFN.Focus();
                        return;
                    }
                    if (int.TryParse(txtLN.Text, out LN))
                    {
                        txtLN.SelectionStart = 0;
                        txtLN.SelectionLength = txtLN.TextLength;
                        txtLN.Focus();
                        return;
                    }
                }
                else
                {
                    data = "Profile\nName: " + txtFN.Text + " " + txtLN.Text;
                    if (rdoMale.Checked == true)
                        data += "\nSex: Male";
                    if (rdoFemale.Checked == true)
                        data += "\nSex: Female";
                    if (mtbContact.Text != "")
                        data += "\nContact Number: " + mtbContact.Text;
                    else
                    {
                        MessageBox.Show("Field cannot be empty.", "Warning!");
                        mtbContact.Focus();
                    }
                    data += "\nBirth Date: " + dtpBD.Value.Date.Month + "/" + dtpBD.Value.Date.Day + "/" + dtpBD.Value.Date.Year;
                    data += "\nAge: " + nudAge.Value.ToString();
                    if (txtEmail.Text != "")
                    {
                        if (int.TryParse(txtEmail.Text, out Em))
                        {
                            MessageBox.Show("Invalid data was input.", "Warning!");
                            txtLN.SelectionStart = 0;
                            txtLN.SelectionLength = txtLN.TextLength;
                            txtLN.Focus();
                            return;
                        }
                        else
                        {
                            data += "\nEmail: " + txtEmail.Text;
                            if (textBoxAddress.Text == "")
                            {
                                MessageBox.Show("Field cannot be empty.", "Warning!");
                                textBoxAddress.Focus();
                                return;
                            }
                            else
                            {
                                if (int.TryParse(textBoxAddress.Text, out Ad))
                                {
                                    MessageBox.Show("Invalid data was input.", "Warning!");
                                    textBoxAddress.SelectionStart = 0;
                                    textBoxAddress.SelectionLength = textBoxAddress.TextLength;
                                    textBoxAddress.Focus();
                                    return;
                                }
                                else
                                {
                                    data += "\nAddress: " + textBoxAddress.Text + "\n\nVaccination Setting\nDate: " + calendarDate.SelectionRange.Start.ToShortDateString();
                                    ;
                                    if (txtLoc.Text == "")
                                    {
                                        MessageBox.Show("Field cannot be empty.", "Warning!");
                                        txtLoc.Focus();
                                        return;
                                    }
                                    else
                                    {
                                        if (int.TryParse(txtLoc.Text, out Loc))
                                        {
                                            MessageBox.Show("Invalid data was input.", "Warning!");
                                            txtLoc.SelectionStart = 0;
                                            txtLoc.SelectionLength = textBoxAddress.TextLength;
                                            txtLoc.Focus();
                                            return;
                                        }
                                        else
                                            data += "\nLocation: " + txtLoc.Text;
                                        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                                        DialogResult result = MessageBox.Show(data + "\n\nPress 'Yes' to finalize your registration.\nPress 'No' to discard current form and answer new one.\nPress 'Cancel' to exit the form","Information Summary", buttons);
                                        if (result == DialogResult.Yes)
                                        {
                                            notifyIcon1.Icon = SystemIcons.Application;
                                            notifyIcon1.ShowBalloonTip(1000);
                                            btnExit.Focus();
                                        }
                                        if (result == DialogResult.No)
                                        {
                                            frmVac f = new frmVac();
                                            f.Show();
                                            this.Hide();
                                        }
                                        if (result == DialogResult.Cancel)
                                            Application.Exit();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Field cannot be empty.", "Warning!");
                        txtEmail.Focus();
                        return;
                    }
                }
            }
            if (txtFN.Text == "")
            {
                MessageBox.Show("Field cannot be empty.", "Warning!");
                txtFN.Focus();
                return;
            }
            if (txtLN.Text == "")
            {
                MessageBox.Show("Field cannot be empty.", "Warning!");
                txtLN.Focus();
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pBar.Value = 80;
            if (textBoxAddress.Text != "")
                calendarDate.Enabled = true;
        }

        private void frmVac_Load(object sender, EventArgs e)
        {
            toolTipSubmit.SetToolTip(btnSubmit, "Click to generate the summary of data");
            toolTipClear.SetToolTip(btnClear, "Click to clear the form");
            toolTipExit.SetToolTip(btnExit, "Click to exit");
            notifyIcon2.Icon = SystemIcons.Application;
            notifyIcon2.ShowBalloonTip(1000);
            txtLN.Enabled = false;
            rdoFemale.Enabled = false;
            rdoMale.Enabled = false;
            mtbContact.Enabled = false;
            calendarDate.Enabled = false;
            nudAge.Enabled = false;
            txtEmail.Enabled = false;
            textBoxAddress.Enabled = false;
            dtpBD.Enabled = false;
            txtLoc.Enabled = false;
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {
            pBar.Value = 20;
            if (txtFN.Text != "")
            {
                rdoFemale.Enabled = true;
                rdoMale.Enabled = true;
            }
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            pBar.Value = 10;
            if (txtFN.Text != "")
                txtLN.Enabled = true;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            pBar.Value = 30;
            if (rdoFemale.Checked == true)
            {
                mtbContact.Enabled = true;
                nudAge.Enabled = true;
            }
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            pBar.Value = 30;
            if (rdoMale.Checked == true)
            {
                mtbContact.Enabled = true;
                nudAge.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtbContact_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pBar.Value = 40;
            dtpBD.Enabled = true;
        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            pBar.Value = 50;
            txtEmail.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            pBar.Value = 60;
            if (txtEmail.Text != "")
                dtpBD.Enabled = true;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            pBar.Value = 70;
            textBoxAddress.Enabled = true;
        }

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {
            pBar.Value = 100;
        }

        private void pBar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            pBar.Value = 90;
            txtLoc.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmVac f = new frmVac();
            f.Show();
            this.Hide();
        }

        private void pBar2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
