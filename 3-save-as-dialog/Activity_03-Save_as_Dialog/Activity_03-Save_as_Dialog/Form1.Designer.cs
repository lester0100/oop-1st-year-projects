
namespace Activity_03_Save_as_Dialog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblActivity = new System.Windows.Forms.Label();
            lbl03 = new System.Windows.Forms.Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            btnRun = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblActivity
            // 
            lblActivity.BackColor = System.Drawing.SystemColors.Window;
            lblActivity.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lblActivity.ForeColor = System.Drawing.SystemColors.WindowText;
            lblActivity.Location = new System.Drawing.Point(12, 9);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new System.Drawing.Size(115, 47);
            lblActivity.TabIndex = 0;
            lblActivity.Text = "Activity";
            // 
            // lbl03
            // 
            lbl03.BackColor = System.Drawing.SystemColors.Window;
            lbl03.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lbl03.ForeColor = System.Drawing.SystemColors.WindowText;
            lbl03.Location = new System.Drawing.Point(573, 317);
            lbl03.Name = "lbl03";
            lbl03.Size = new System.Drawing.Size(47, 47);
            lbl03.TabIndex = 1;
            lbl03.Text = "03";
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(225, 200);
            progressBar1.Maximum = 760;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(157, 23);
            progressBar1.TabIndex = 4;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnRun
            // 
            btnRun.BackColor = System.Drawing.SystemColors.Window;
            btnRun.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            btnRun.Location = new System.Drawing.Point(225, 149);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(157, 58);
            btnRun.TabIndex = 7;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.SystemColors.Window;
            btnStart.Enabled = false;
            btnStart.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            btnStart.Location = new System.Drawing.Point(250, 240);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(108, 40);
            btnStart.TabIndex = 8;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Visible = false;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            ClientSize = new System.Drawing.Size(632, 373);
            Controls.Add(btnStart);
            Controls.Add(btnRun);
            Controls.Add(progressBar1);
            Controls.Add(lbl03);
            Controls.Add(lblActivity);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStart;
    }
}