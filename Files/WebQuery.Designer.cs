namespace TelusEarningsCalculator
{
    partial class WebQuery
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
            tbResult = new TextBox();
            button1 = new Button();
            label9 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            tbPE330 = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            tbPE150 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            tbPE120 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbResult
            // 
            tbResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbResult.Location = new Point(819, 502);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(314, 71);
            tbResult.TabIndex = 76;
            tbResult.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 22.125F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(760, 380);
            button1.Name = "button1";
            button1.Size = new Size(455, 107);
            button1.TabIndex = 75;
            button1.Text = "Earnings Count!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 309);
            label9.Name = "label9";
            label9.Size = new Size(0, 32);
            label9.TabIndex = 74;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(tbPE330);
            panel3.Location = new Point(1221, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 46);
            panel3.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(196, 45);
            label6.TabIndex = 2;
            label6.Text = "135 seconds";
            // 
            // tbPE330
            // 
            tbPE330.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPE330.Location = new Point(195, 4);
            tbPE330.Name = "tbPE330";
            tbPE330.Size = new Size(90, 39);
            tbPE330.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1215, 223);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 72;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbPE150);
            panel2.Location = new Point(843, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 46);
            panel2.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(197, 45);
            label4.TabIndex = 2;
            label4.Text = "90 seconds  ";
            // 
            // tbPE150
            // 
            tbPE150.Location = new Point(199, 4);
            tbPE150.Name = "tbPE150";
            tbPE150.Size = new Size(91, 39);
            tbPE150.TabIndex = 3;
            tbPE150.TextChanged += tbPE150_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(860, 216);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 70;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbPE120);
            panel1.Location = new Point(491, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 46);
            panel1.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 3);
            label3.Name = "label3";
            label3.Size = new Size(197, 45);
            label3.TabIndex = 2;
            label3.Text = "45 seconds  ";
            // 
            // tbPE120
            // 
            tbPE120.Location = new Point(195, 4);
            tbPE120.Name = "tbPE120";
            tbPE120.Size = new Size(90, 39);
            tbPE120.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 219);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(697, 93);
            label1.Name = "label1";
            label1.Size = new Size(575, 59);
            label1.TabIndex = 67;
            label1.Text = "Please Insert your Task Count";
            // 
            // WebQuery
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 985);
            Controls.Add(tbResult);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WebQuery";
            Text = "WebQuery";
            Load += WebQuery_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResult;
        private Button button1;
        private Label label9;
        private Panel panel3;
        private Label label6;
        private TextBox tbPE330;
        private Label label7;
        private Panel panel2;
        private Label label4;
        private TextBox tbPE150;
        private Label label5;
        private Panel panel1;
        private Label label3;
        private TextBox tbPE120;
        private Label label2;
        private Label label1;
    }
}