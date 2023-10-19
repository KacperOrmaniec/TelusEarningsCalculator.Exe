namespace TelusEarningsCalculator
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnExit = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            menuContainer = new FlowLayoutPanel();
            panel12 = new Panel();
            button10 = new Button();
            panel3 = new Panel();
            Search20 = new Button();
            panel4 = new Panel();
            poiEvaluation = new Button();
            panel6 = new Panel();
            autocomplete = new Button();
            panel7 = new Panel();
            searchAds = new Button();
            panel8 = new Panel();
            searchSbs = new Button();
            panel9 = new Panel();
            webQuery = new Button();
            panel10 = new Panel();
            other = new Button();
            button9 = new Button();
            EarningsContainer = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            menuContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 67);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1509, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(52, 47);
            btnExit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnExit.TabIndex = 3;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 12);
            label1.Name = "label1";
            label1.Size = new Size(736, 44);
            label1.TabIndex = 2;
            label1.Text = "TELUS International Earnings Calculator";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Lavender;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(menuContainer);
            sidebar.Location = new Point(-1, 67);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(404, 921);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 87);
            panel2.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(-10, -19);
            button3.Name = "button3";
            button3.Size = new Size(381, 124);
            button3.TabIndex = 5;
            button3.Text = "Task Rates";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.Lavender;
            menuContainer.Controls.Add(panel12);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel4);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel8);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel10);
            menuContainer.Location = new Point(3, 96);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(392, 79);
            menuContainer.TabIndex = 8;
            // 
            // panel12
            // 
            panel12.Controls.Add(button10);
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(392, 73);
            panel12.TabIndex = 17;
            // 
            // button10
            // 
            button10.BackColor = Color.Lavender;
            button10.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(-19, -23);
            button10.Name = "button10";
            button10.Size = new Size(430, 119);
            button10.TabIndex = 9;
            button10.Text = "Earnings Calculator";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Search20);
            panel3.Location = new Point(3, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 83);
            panel3.TabIndex = 9;
            // 
            // Search20
            // 
            Search20.BackColor = Color.Lavender;
            Search20.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Search20.ForeColor = SystemColors.ActiveCaptionText;
            Search20.Location = new Point(-19, -12);
            Search20.Name = "Search20";
            Search20.Size = new Size(430, 108);
            Search20.TabIndex = 2;
            Search20.Text = "Search 2.0";
            Search20.TextImageRelation = TextImageRelation.ImageBeforeText;
            Search20.UseVisualStyleBackColor = false;
            Search20.Click += Search20_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(poiEvaluation);
            panel4.Location = new Point(3, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 70);
            panel4.TabIndex = 10;
            // 
            // poiEvaluation
            // 
            poiEvaluation.BackColor = Color.Lavender;
            poiEvaluation.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            poiEvaluation.ForeColor = SystemColors.ActiveCaptionText;
            poiEvaluation.Location = new Point(-20, -23);
            poiEvaluation.Name = "poiEvaluation";
            poiEvaluation.Size = new Size(430, 108);
            poiEvaluation.TabIndex = 9;
            poiEvaluation.Text = "POI Evaluation";
            poiEvaluation.TextImageRelation = TextImageRelation.ImageBeforeText;
            poiEvaluation.UseVisualStyleBackColor = false;
            poiEvaluation.Click += poiEvaluation_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(autocomplete);
            panel6.Location = new Point(3, 247);
            panel6.Name = "panel6";
            panel6.Size = new Size(392, 70);
            panel6.TabIndex = 11;
            // 
            // autocomplete
            // 
            autocomplete.BackColor = Color.Lavender;
            autocomplete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autocomplete.ForeColor = SystemColors.ActiveCaptionText;
            autocomplete.Location = new Point(-20, -23);
            autocomplete.Name = "autocomplete";
            autocomplete.Size = new Size(430, 108);
            autocomplete.TabIndex = 9;
            autocomplete.Text = "Autocomplete";
            autocomplete.TextImageRelation = TextImageRelation.ImageBeforeText;
            autocomplete.UseVisualStyleBackColor = false;
            autocomplete.Click += autocomplete_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchAds);
            panel7.Location = new Point(3, 323);
            panel7.Name = "panel7";
            panel7.Size = new Size(392, 70);
            panel7.TabIndex = 12;
            // 
            // searchAds
            // 
            searchAds.BackColor = Color.Lavender;
            searchAds.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchAds.ForeColor = SystemColors.ActiveCaptionText;
            searchAds.Location = new Point(-20, -23);
            searchAds.Name = "searchAds";
            searchAds.Size = new Size(430, 108);
            searchAds.TabIndex = 9;
            searchAds.Text = "Search Ads C.V";
            searchAds.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchAds.UseVisualStyleBackColor = false;
            searchAds.Click += searchAds_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(searchSbs);
            panel8.Location = new Point(3, 399);
            panel8.Name = "panel8";
            panel8.Size = new Size(392, 70);
            panel8.TabIndex = 13;
            // 
            // searchSbs
            // 
            searchSbs.BackColor = Color.Lavender;
            searchSbs.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchSbs.ForeColor = SystemColors.ActiveCaptionText;
            searchSbs.Location = new Point(-20, -23);
            searchSbs.Name = "searchSbs";
            searchSbs.Size = new Size(430, 108);
            searchSbs.TabIndex = 9;
            searchSbs.Text = "Search SBS";
            searchSbs.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchSbs.UseVisualStyleBackColor = false;
            searchSbs.Click += searchSbs_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(webQuery);
            panel9.Location = new Point(3, 475);
            panel9.Name = "panel9";
            panel9.Size = new Size(392, 70);
            panel9.TabIndex = 14;
            // 
            // webQuery
            // 
            webQuery.BackColor = Color.Lavender;
            webQuery.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            webQuery.ForeColor = SystemColors.ActiveCaptionText;
            webQuery.Location = new Point(-20, -23);
            webQuery.Name = "webQuery";
            webQuery.Size = new Size(430, 108);
            webQuery.TabIndex = 9;
            webQuery.Text = "Web Query Classification";
            webQuery.TextImageRelation = TextImageRelation.ImageBeforeText;
            webQuery.UseVisualStyleBackColor = false;
            webQuery.Click += webQuery_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(other);
            panel10.Location = new Point(3, 551);
            panel10.Name = "panel10";
            panel10.Size = new Size(392, 70);
            panel10.TabIndex = 15;
            // 
            // other
            // 
            other.BackColor = Color.Lavender;
            other.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            other.ForeColor = SystemColors.ActiveCaptionText;
            other.Location = new Point(-20, -23);
            other.Name = "other";
            other.Size = new Size(430, 108);
            other.TabIndex = 9;
            other.Text = "other";
            other.TextImageRelation = TextImageRelation.ImageBeforeText;
            other.UseVisualStyleBackColor = false;
            other.Click += other_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Lavender;
            button9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(573, 638);
            button9.Name = "button9";
            button9.Size = new Size(0, 0);
            button9.TabIndex = 9;
            button9.Text = "Earnings Calculator";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // EarningsContainer
            // 
            EarningsContainer.Interval = 6;
            EarningsContainer.Tick += EarningsContainer_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 6;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1571, 985);
            Controls.Add(button9);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnExit;
        private FlowLayoutPanel sidebar;
        private Button button3;
        private Button Search20;
        private Panel panel2;
        private FlowLayoutPanel menuContainer;
        private Panel panel3;
        private Button poiEvaluation;
        private Panel panel4;
        private Panel panel6;
        private Button autocomplete;
        private Panel panel7;
        private Button searchAds;
        private Panel panel8;
        private Button searchSbs;
        private Panel panel9;
        private Button webQuery;
        private Panel panel10;
        private Button other;
        private Button button9;
        private Panel panel12;
        private Button button10;
        private System.Windows.Forms.Timer EarningsContainer;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}