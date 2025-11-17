
namespace WinFormsAppSample2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProgram1 = new System.Windows.Forms.Button();
            btnProgram3 = new System.Windows.Forms.Button();
            btnProgram2 = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnProgram5 = new System.Windows.Forms.Button();
            btnProgram4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnProgram1
            // 
            btnProgram1.BackColor = System.Drawing.SystemColors.WindowText;
            btnProgram1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            btnProgram1.ForeColor = System.Drawing.SystemColors.Window;
            btnProgram1.Location = new System.Drawing.Point(259, 27);
            btnProgram1.Name = "btnProgram1";
            btnProgram1.Size = new System.Drawing.Size(141, 45);
            btnProgram1.TabIndex = 0;
            btnProgram1.Text = "Program 1";
            btnProgram1.UseVisualStyleBackColor = false;
            btnProgram1.Click += button1_Click;
            // 
            // btnProgram3
            // 
            btnProgram3.BackColor = System.Drawing.SystemColors.WindowText;
            btnProgram3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            btnProgram3.ForeColor = System.Drawing.SystemColors.Window;
            btnProgram3.Location = new System.Drawing.Point(259, 129);
            btnProgram3.Name = "btnProgram3";
            btnProgram3.Size = new System.Drawing.Size(141, 45);
            btnProgram3.TabIndex = 1;
            btnProgram3.Text = "Program 3";
            btnProgram3.UseVisualStyleBackColor = false;
            btnProgram3.Click += button2_Click;
            // 
            // btnProgram2
            // 
            btnProgram2.BackColor = System.Drawing.SystemColors.WindowText;
            btnProgram2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            btnProgram2.ForeColor = System.Drawing.SystemColors.Window;
            btnProgram2.Location = new System.Drawing.Point(259, 78);
            btnProgram2.Name = "btnProgram2";
            btnProgram2.Size = new System.Drawing.Size(141, 45);
            btnProgram2.TabIndex = 2;
            btnProgram2.Text = "Program 2";
            btnProgram2.UseVisualStyleBackColor = false;
            btnProgram2.Click += button3_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.WindowText;
            btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            btnExit.ForeColor = System.Drawing.SystemColors.Window;
            btnExit.Location = new System.Drawing.Point(540, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 33);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button4_Click;
            // 
            // btnProgram5
            // 
            btnProgram5.BackColor = System.Drawing.SystemColors.WindowText;
            btnProgram5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            btnProgram5.ForeColor = System.Drawing.SystemColors.Window;
            btnProgram5.Location = new System.Drawing.Point(259, 231);
            btnProgram5.Name = "btnProgram5";
            btnProgram5.Size = new System.Drawing.Size(141, 45);
            btnProgram5.TabIndex = 4;
            btnProgram5.Text = "Program 5";
            btnProgram5.UseVisualStyleBackColor = false;
            btnProgram5.Click += button1_Click_1;
            // 
            // btnProgram4
            // 
            btnProgram4.BackColor = System.Drawing.SystemColors.WindowText;
            btnProgram4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            btnProgram4.ForeColor = System.Drawing.SystemColors.Window;
            btnProgram4.Location = new System.Drawing.Point(259, 180);
            btnProgram4.Name = "btnProgram4";
            btnProgram4.Size = new System.Drawing.Size(141, 45);
            btnProgram4.TabIndex = 5;
            btnProgram4.Text = "Program 4";
            btnProgram4.UseVisualStyleBackColor = false;
            btnProgram4.Click += button2_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._41b0277a3ab0c79810223b33aee109a7;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(654, 361);
            Controls.Add(btnProgram4);
            Controls.Add(btnProgram5);
            Controls.Add(btnExit);
            Controls.Add(btnProgram2);
            Controls.Add(btnProgram3);
            Controls.Add(btnProgram1);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgram1;
        private System.Windows.Forms.Button btnProgram3;
        private System.Windows.Forms.Button btnProgram2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProgram5;
        private System.Windows.Forms.Button btnProgram4;
    }
}

