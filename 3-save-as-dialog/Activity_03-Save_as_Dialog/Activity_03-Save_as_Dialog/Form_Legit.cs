using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Activity_03_Save_as_Dialog
{
    public partial class Form_Legit : Form
    {
        public Form_Legit()
        {
            InitializeComponent();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open image file";
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg| PNG files|*.png| GIF Files|*.gif| TIFF Files|*.tif; *.tiff| Bitmap Files|*.bmp| EPS Files|*.eps| RAW Image Files|*.raw;*.cr2;*.nef;*.orf;*.sr2| Image Editor Files|*.psd;*.xcf;*.ai;*.cdr";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnUT_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open text file";
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "RTF files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else
            {
                saveFileDialog1.Title = "Save RTF file";
                saveFileDialog1.DefaultExt = "rtf";
                saveFileDialog1.Filter = "RTF files|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    richTextBox1.Text = saveFileDialog1.FileName;
            }
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                notifyIcon2.Icon = SystemIcons.Exclamation;
                notifyIcon2.ShowBalloonTip(1000);
            }
            else
            {
                saveFileDialog1.Title = "Save image file";
                saveFileDialog1.DefaultExt = "jpg";
                saveFileDialog1.Filter = "JPEG Files|*.jpg;*.jpeg| PNG files|*.png| GIF Files|*.gif| TIFF Files|*.tif; *.tiff| Bitmap Files|*.bmp| EPS Files|*.eps| RAW Image Files|*.raw;*.cr2;*.nef;*.orf;*.sr2| Image Editor Files|*.psd;*.xcf;*.ai;*.cdr";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip1.Show(pictureBox1, e.Location);
            }
        }

        private void contextMenuStrip2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip2.Show(richTextBox1, e.Location);
            }
        }

        private void Form_Legit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnUP, "Click to upload photo from this device");
            toolTip2.SetToolTip(btnSP, "Click to save photo in this device");
            toolTip3.SetToolTip(btnUT, "Click to upload text from this device");
            toolTip4.SetToolTip(btnST, "Click to save text in this device");
        }
    }
}
