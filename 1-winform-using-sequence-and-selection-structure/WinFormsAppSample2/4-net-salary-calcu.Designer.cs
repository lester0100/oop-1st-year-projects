
namespace WinFormsAppSample2
{
    partial class Program4Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program4Form));
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblResult = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtGS = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.WindowText;
            button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.SystemColors.Window;
            button2.Location = new System.Drawing.Point(514, 315);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 30);
            button2.TabIndex = 3;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.WindowText;
            button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.SystemColors.Window;
            button1.Location = new System.Drawing.Point(408, 315);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 30);
            button1.TabIndex = 4;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGS);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            groupBox1.Location = new System.Drawing.Point(40, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(574, 297);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Net Salary Calculator";
            groupBox1.Enter += groupBox1_Enter;
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
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Window;
            label3.ForeColor = System.Drawing.SystemColors.WindowText;
            label3.Location = new System.Drawing.Point(76, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(224, 19);
            label3.TabIndex = 12;
            label3.Text = "Enter the value for gross salary:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 19);
            label1.TabIndex = 10;
            // 
            // txtGS
            // 
            txtGS.ForeColor = System.Drawing.SystemColors.WindowText;
            txtGS.Location = new System.Drawing.Point(316, 89);
            txtGS.Name = "txtGS";
            txtGS.Size = new System.Drawing.Size(176, 26);
            txtGS.TabIndex = 7;
            txtGS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtGS.TextChanged += txtGS_TextChanged;
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
            // Program4Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowText;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(654, 361);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Program4Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Net Salary Program - Form 4/5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGS;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}