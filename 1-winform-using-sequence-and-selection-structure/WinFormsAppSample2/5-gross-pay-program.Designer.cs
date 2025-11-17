namespace WinFormsAppSample2
{
    partial class Program5Form
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
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtHours = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblResult = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtRate = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.WindowText;
            button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            button3.ForeColor = System.Drawing.SystemColors.Window;
            button3.Location = new System.Drawing.Point(362, 315);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(80, 30);
            button3.TabIndex = 4;
            button3.Text = "Previous";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.WindowText;
            button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            button4.ForeColor = System.Drawing.SystemColors.Window;
            button4.Location = new System.Drawing.Point(534, 315);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(80, 30);
            button4.TabIndex = 5;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.WindowText;
            button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.SystemColors.Window;
            button1.Location = new System.Drawing.Point(448, 315);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(80, 30);
            button1.TabIndex = 6;
            button1.Text = "Main";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            groupBox1.Controls.Add(txtHours);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRate);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            groupBox1.Location = new System.Drawing.Point(40, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(574, 297);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gross Pay Calculator";
            // 
            // txtHours
            // 
            txtHours.ForeColor = System.Drawing.SystemColors.WindowText;
            txtHours.Location = new System.Drawing.Point(342, 114);
            txtHours.Name = "txtHours";
            txtHours.Size = new System.Drawing.Size(176, 26);
            txtHours.TabIndex = 17;
            txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.SystemColors.Window;
            label4.ForeColor = System.Drawing.SystemColors.WindowText;
            label4.Location = new System.Drawing.Point(57, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(240, 19);
            label4.TabIndex = 16;
            label4.Text = "Enter the amount of hours worked:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblResult);
            groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            groupBox2.ForeColor = System.Drawing.Color.Black;
            groupBox2.Location = new System.Drawing.Point(57, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(461, 82);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.BackColor = System.Drawing.SystemColors.WindowText;
            lblResult.ForeColor = System.Drawing.SystemColors.Window;
            lblResult.Location = new System.Drawing.Point(6, 15);
            lblResult.Multiline = true;
            lblResult.Name = "lblResult";
            lblResult.ReadOnly = true;
            lblResult.Size = new System.Drawing.Size(449, 61);
            lblResult.TabIndex = 0;
            lblResult.TextChanged += lblResult_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.SystemColors.Window;
            label3.ForeColor = System.Drawing.SystemColors.WindowText;
            label3.Location = new System.Drawing.Point(57, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(240, 19);
            label3.TabIndex = 12;
            label3.Text = "Enter rate per hour value:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 19);
            label1.TabIndex = 10;
            // 
            // txtRate
            // 
            txtRate.ForeColor = System.Drawing.SystemColors.WindowText;
            txtRate.Location = new System.Drawing.Point(342, 52);
            txtRate.Name = "txtRate";
            txtRate.Size = new System.Drawing.Size(176, 26);
            txtRate.TabIndex = 7;
            txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = System.Drawing.SystemColors.WindowText;
            btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            btnCalculate.ForeColor = System.Drawing.SystemColors.Window;
            btnCalculate.Location = new System.Drawing.Point(191, 261);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(83, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.SystemColors.WindowText;
            btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            btnClear.ForeColor = System.Drawing.SystemColors.Window;
            btnClear.Location = new System.Drawing.Point(299, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(83, 30);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Program5Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowText;
            BackgroundImage = Properties.Resources.dark_blue_bg;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(654, 361);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            ForeColor = System.Drawing.SystemColors.WindowText;
            Name = "Program5Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gross Pay Program - Form 5/5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}