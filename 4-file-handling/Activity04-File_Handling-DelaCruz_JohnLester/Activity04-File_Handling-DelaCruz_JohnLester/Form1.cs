using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity04_File_Handling_DelaCruz_JohnLester
{
    public partial class Form1 : Form
    {
        readonly string exePath = AppDomain.CurrentDomain.BaseDirectory;
        readonly string dataPath;
        readonly string supportPath;

        public Form1()
        {
            InitializeComponent();
            dataPath = Path.Combine(exePath, "Data.txt");
            supportPath = Path.Combine(exePath, "Support.txt");
        }

        public void LoadContent(string f)
        {
            string fileContent = "";
            try
            {
                FileStream fs = new FileStream(dataPath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while (line != null)
                {
                    fileContent += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
                lblText.Text = fileContent;
                sr.Close();
                fs.Close();
            }
            catch (IOException IO)
            {
                MessageBox.Show(IO.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtLN.Text == "") || (txtFN.Text == "") || (txtAge.Text == ""))
            {
                if (txtLN.Text == "")
                {
                    MessageBox.Show("This field is required", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtLN.Focus();
                    return;
                }
                if (txtFN.Text == "")
                {
                    MessageBox.Show("This field is required", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtFN.Focus();
                    return;
                }
                if (txtAge.Text == "")
                {
                    MessageBox.Show("This field is required", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtAge.Focus();
                    return;
                }
            }
            else
            {
                int firstname, lastname, age;
                if ((int.TryParse(txtLN.Text, out lastname)) || (int.TryParse(txtFN.Text, out firstname)))
                {
                    if (int.TryParse(txtLN.Text, out lastname))
                    {
                        MessageBox.Show("Invalid Data was input", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtLN.SelectionStart = 0;
                        txtLN.SelectionLength = txtLN.TextLength;
                        txtLN.Focus();
                        return;
                    }
                    if (int.TryParse(txtFN.Text, out firstname))
                    {
                        MessageBox.Show("Invalid Data was input", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtFN.SelectionStart = 0;
                        txtFN.SelectionLength = txtFN.TextLength;
                        txtFN.Focus();
                        return;
                    }
                }
                else
                {
                    if (int.TryParse(txtAge.Text, out age))
                    {
                        string line = null;
                        string[] lineContent;
                        string LNUpdate = txtLN.Text.Trim();

                        StreamReader sr = new StreamReader(dataPath);
                        StreamWriter sw = new StreamWriter(supportPath);
                        while ((line = sr.ReadLine()) != null)
                        {
                            lineContent = line.Split(",");
                            if (lineContent[0] == LNUpdate)
                            {
                                sw.WriteLine(txtLN.Text + "," + txtFN.Text + "," + txtAge.Text);
                                continue;
                            }
                            sw.WriteLine(line);
                        }
                        sr.Close();
                        sw.Close();
                        File.Copy(supportPath, dataPath, true);
                        LoadContent(dataPath);
                        MessageBox.Show("Data has been updated", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        txtLN.Text = "";
                        txtFN.Text = "";
                        txtAge.Text = "";
                        txtLN.Focus();
                        txtFN.Enabled = false;
                        txtAge.Enabled = false;
                        btnClear.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Data was input", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtAge.SelectionStart = 0;
                        txtAge.SelectionLength = txtAge.TextLength;
                        txtAge.Focus();
                        return;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContent(dataPath);
            txtLN.Focus();
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(dataPath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                string[] lineContent;
                while (line != null)
                {
                    lineContent = line.Split(",");
                    if (lineContent[0] == txtLN.Text.Trim())
                    {
                        txtFN.Enabled = true;
                        txtAge.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnClear.Enabled = true;
                        txtFN.Text = lineContent[1];
                        txtAge.Text = lineContent[2];
                        break;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLN.Text = "";
            txtFN.Text = "";
            txtAge.Text = "";
        }
    }
}
