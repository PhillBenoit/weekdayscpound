namespace weekdayscpound
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
            dudMonth = new DomainUpDown();
            lblMonth = new Label();
            nudYear = new NumericUpDown();
            lblYear = new Label();
            lblDOTW = new Label();
            dudDOTW = new DomainUpDown();
            lbl1 = new Label();
            lbl1st = new Label();
            lbl2nd = new Label();
            lbl2 = new Label();
            lbl4th = new Label();
            lbl4 = new Label();
            lbl3rd = new Label();
            lbl3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // dudMonth
            // 
            dudMonth.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dudMonth.Items.Add("January");
            dudMonth.Items.Add("February");
            dudMonth.Items.Add("March");
            dudMonth.Items.Add("April");
            dudMonth.Items.Add("May");
            dudMonth.Items.Add("June");
            dudMonth.Items.Add("July");
            dudMonth.Items.Add("August");
            dudMonth.Items.Add("September");
            dudMonth.Items.Add("October");
            dudMonth.Items.Add("November");
            dudMonth.Items.Add("December");
            dudMonth.Location = new Point(19, 69);
            dudMonth.Name = "dudMonth";
            dudMonth.Size = new Size(193, 39);
            dudMonth.TabIndex = 0;
            dudMonth.Wrap = true;
            dudMonth.SelectedItemChanged += LoadDays;
            // 
            // lblMonth
            // 
            lblMonth.Font = new Font("Arial", 16.2F);
            lblMonth.Location = new Point(19, 25);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(193, 41);
            lblMonth.TabIndex = 1;
            lblMonth.Text = "Month";
            lblMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudYear
            // 
            nudYear.Font = new Font("Arial", 16.2F);
            nudYear.Location = new Point(218, 69);
            nudYear.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1752, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(94, 39);
            nudYear.TabIndex = 2;
            nudYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            nudYear.ValueChanged += LoadDays;
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Arial", 16.2F);
            lblYear.Location = new Point(218, 25);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(94, 41);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year";
            lblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDOTW
            // 
            lblDOTW.Font = new Font("Arial", 16.2F);
            lblDOTW.Location = new Point(318, 25);
            lblDOTW.Name = "lblDOTW";
            lblDOTW.Size = new Size(230, 41);
            lblDOTW.TabIndex = 4;
            lblDOTW.Text = "Day of the Week";
            lblDOTW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dudDOTW
            // 
            dudDOTW.Font = new Font("Arial", 16.2F);
            dudDOTW.Items.Add("Sunday");
            dudDOTW.Items.Add("Monday");
            dudDOTW.Items.Add("Tuesday");
            dudDOTW.Items.Add("Wednesday");
            dudDOTW.Items.Add("Thursday");
            dudDOTW.Items.Add("Friday");
            dudDOTW.Items.Add("Saturday");
            dudDOTW.Location = new Point(318, 69);
            dudDOTW.Name = "dudDOTW";
            dudDOTW.Size = new Size(230, 39);
            dudDOTW.TabIndex = 5;
            dudDOTW.Wrap = true;
            dudDOTW.SelectedItemChanged += LoadDays;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Arial", 16.2F);
            lbl1.Location = new Point(118, 133);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(71, 41);
            lbl1.TabIndex = 6;
            lbl1.Text = "1st";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1st
            // 
            lbl1st.Font = new Font("Arial", 16.2F);
            lbl1st.Location = new Point(118, 174);
            lbl1st.Name = "lbl1st";
            lbl1st.Size = new Size(71, 41);
            lbl1st.TabIndex = 7;
            lbl1st.Text = "00";
            lbl1st.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2nd
            // 
            lbl2nd.Font = new Font("Arial", 16.2F);
            lbl2nd.Location = new Point(195, 174);
            lbl2nd.Name = "lbl2nd";
            lbl2nd.Size = new Size(71, 41);
            lbl2nd.TabIndex = 9;
            lbl2nd.Text = "00";
            lbl2nd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Arial", 16.2F);
            lbl2.Location = new Point(195, 133);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(71, 41);
            lbl2.TabIndex = 8;
            lbl2.Text = "2nd";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4th
            // 
            lbl4th.Font = new Font("Arial", 16.2F);
            lbl4th.Location = new Point(349, 174);
            lbl4th.Name = "lbl4th";
            lbl4th.Size = new Size(71, 41);
            lbl4th.TabIndex = 13;
            lbl4th.Text = "00";
            lbl4th.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            lbl4.Font = new Font("Arial", 16.2F);
            lbl4.Location = new Point(349, 133);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(71, 41);
            lbl4.TabIndex = 12;
            lbl4.Text = "4th";
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3rd
            // 
            lbl3rd.Font = new Font("Arial", 16.2F);
            lbl3rd.Location = new Point(272, 174);
            lbl3rd.Name = "lbl3rd";
            lbl3rd.Size = new Size(71, 41);
            lbl3rd.TabIndex = 11;
            lbl3rd.Text = "00";
            lbl3rd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.Font = new Font("Arial", 16.2F);
            lbl3.Location = new Point(272, 133);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(71, 41);
            lbl3.TabIndex = 10;
            lbl3.Text = "3rd";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 235);
            Controls.Add(lbl4th);
            Controls.Add(lbl4);
            Controls.Add(lbl3rd);
            Controls.Add(lbl3);
            Controls.Add(lbl2nd);
            Controls.Add(lbl2);
            Controls.Add(lbl1st);
            Controls.Add(lbl1);
            Controls.Add(dudDOTW);
            Controls.Add(lblDOTW);
            Controls.Add(lblYear);
            Controls.Add(nudYear);
            Controls.Add(lblMonth);
            Controls.Add(dudMonth);
            Name = "Form1";
            Text = "Day of the Week Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DomainUpDown dudMonth;
        private Label lblMonth;
        private NumericUpDown nudYear;
        private Label lblYear;
        private Label lblDOTW;
        private DomainUpDown dudDOTW;
        private Label lbl1;
        private Label lbl1st;
        private Label lbl2nd;
        private Label lbl2;
        private Label lbl4th;
        private Label lbl4;
        private Label lbl3rd;
        private Label lbl3;
    }
}
