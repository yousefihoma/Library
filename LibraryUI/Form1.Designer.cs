namespace LibraryUI
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
            panel1 = new Panel();
            lblFine = new Label();
            lblTime = new Label();
            lblDate = new Label();
            lblAboutUs = new Label();
            label6 = new Label();
            label7 = new Label();
            lblExit = new Label();
            plnSide = new Panel();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblTempExit = new Label();
            lblHistory = new Label();
            lblReport = new Label();
            panel2 = new Panel();
            lblUserName = new Label();
            lblMinimize = new Label();
            pictureBox1 = new PictureBox();
            btnMembers = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblFine);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblAboutUs);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(plnSide);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTempExit);
            panel1.Controls.Add(lblHistory);
            panel1.Controls.Add(lblReport);
            panel1.Location = new Point(622, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 423);
            panel1.TabIndex = 1;
            // 
            // lblFine
            // 
            lblFine.AutoSize = true;
            lblFine.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFine.Location = new Point(73, 136);
            lblFine.Name = "lblFine";
            lblFine.Size = new Size(46, 16);
            lblFine.TabIndex = 9;
            lblFine.Text = "جریمه";
            lblFine.Click += lblFine_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTime.Location = new Point(42, 291);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(43, 14);
            lblTime.TabIndex = 4;
            lblTime.Text = "14:30";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDate.Location = new Point(25, 329);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(85, 14);
            lblDate.TabIndex = 5;
            lblDate.Text = "1404/03/01";
            // 
            // lblAboutUs
            // 
            lblAboutUs.AutoSize = true;
            lblAboutUs.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblAboutUs.Location = new Point(42, 367);
            lblAboutUs.Name = "lblAboutUs";
            lblAboutUs.Size = new Size(56, 14);
            lblAboutUs.TabIndex = 8;
            lblAboutUs.Text = "درباره ما";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label6.Location = new Point(18, 216);
            label6.Name = "label6";
            label6.Size = new Size(18, 16);
            label6.TabIndex = 7;
            label6.Text = "<";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(-9, 253);
            label7.Name = "label7";
            label7.Size = new Size(195, 19);
            label7.TabIndex = 6;
            label7.Text = "_______________________________";
            label7.Click += lblExit_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExit.Location = new Point(81, 216);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 19);
            lblExit.TabIndex = 6;
            lblExit.Text = "خروج";
            lblExit.Click += lblExit_Click;
            // 
            // plnSide
            // 
            plnSide.BackColor = Color.FromArgb(192, 192, 255);
            plnSide.Location = new Point(123, 51);
            plnSide.Name = "plnSide";
            plnSide.Size = new Size(22, 28);
            plnSide.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label9.Location = new Point(16, 177);
            label9.Name = "label9";
            label9.Size = new Size(18, 16);
            label9.TabIndex = 4;
            label9.Text = "<";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label5.Location = new Point(19, 138);
            label5.Name = "label5";
            label5.Size = new Size(18, 16);
            label5.TabIndex = 4;
            label5.Text = "<";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label4.Location = new Point(17, 99);
            label4.Name = "label4";
            label4.Size = new Size(18, 16);
            label4.TabIndex = 3;
            label4.Text = "<";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label2.Location = new Point(19, 60);
            label2.Name = "label2";
            label2.Size = new Size(18, 16);
            label2.TabIndex = 2;
            label2.Text = "<";
            // 
            // lblTempExit
            // 
            lblTempExit.AutoSize = true;
            lblTempExit.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempExit.Location = new Point(40, 176);
            lblTempExit.Name = "lblTempExit";
            lblTempExit.Size = new Size(79, 16);
            lblTempExit.TabIndex = 1;
            lblTempExit.Text = "خروج موقت";
            lblTempExit.Click += lblTempExit_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(65, 96);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(54, 16);
            lblHistory.TabIndex = 1;
            lblHistory.Text = "تاریخچه";
            lblHistory.Click += lblHistory_Click;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReport.ForeColor = Color.FromArgb(0, 0, 64);
            lblReport.Location = new Point(70, 56);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(49, 16);
            lblReport.TabIndex = 0;
            lblReport.Text = "گزارش";
            lblReport.Click += lblReport_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(lblMinimize);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 31);
            panel2.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(672, 7);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(73, 14);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "مدیر سیستم";
            // 
            // lblMinimize
            // 
            lblMinimize.AutoSize = true;
            lblMinimize.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinimize.ForeColor = Color.FromArgb(0, 0, 64);
            lblMinimize.Location = new Point(0, -9);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new Size(33, 45);
            lblMinimize.TabIndex = 0;
            lblMinimize.Text = "-";
            lblMinimize.Click += lblMinimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(-204, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(494, 88);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(75, 23);
            btnMembers.TabIndex = 4;
            btnMembers.Text = "button1";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 417);
            Controls.Add(btnMembers);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblMinimize;
        private Label lblReport;
        private Label label2;
        private Label lblHistory;
        private Label lblTempExit;
        private Label label5;
        private Label label4;
        private Panel plnSide;
        private Label lblExit;
        private Label label6;
        private Label lblTime;
        private Label lblDate;
        private Label lblAboutUs;
        private Label label7;
        private Label lblUserName;
        private Label lblFine;
        private Label label9;
        private Button btnMembers;
    }
}
