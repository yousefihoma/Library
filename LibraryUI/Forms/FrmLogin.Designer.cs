namespace LibraryUI.Forms
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            btnLogin = new Button();
            btnExit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblChangePassword = new Label();
            cbxShowPassword = new CheckBox();
            lblUserAndIP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 255);
            btnLogin.ForeColor = Color.FromArgb(0, 0, 70);
            btnLogin.Location = new Point(257, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 255);
            btnExit.ForeColor = Color.FromArgb(0, 0, 70);
            btnExit.Location = new Point(126, 140);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(112, 44);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 23);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(0, 0, 70);
            label1.Location = new Point(356, 47);
            label1.Name = "label1";
            label1.Size = new Size(67, 16);
            label1.TabIndex = 4;
            label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(0, 0, 70);
            label2.Location = new Point(356, 107);
            label2.Name = "label2";
            label2.Size = new Size(57, 16);
            label2.TabIndex = 5;
            label2.Text = "رمز عبور:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Login;
            pictureBox1.Location = new Point(-7, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.BackColor = Color.Transparent;
            lblChangePassword.ForeColor = Color.FromArgb(0, 0, 70);
            lblChangePassword.Location = new Point(246, 190);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(177, 16);
            lblChangePassword.TabIndex = 7;
            lblChangePassword.Text = "رمز عبور خود را فراموش کرده ام";
            lblChangePassword.Click += lblChangePassword_Click;
            // 
            // cbxShowPassword
            // 
            cbxShowPassword.AutoSize = true;
            cbxShowPassword.BackColor = Color.Transparent;
            cbxShowPassword.Location = new Point(12, 106);
            cbxShowPassword.Name = "cbxShowPassword";
            cbxShowPassword.Size = new Size(84, 20);
            cbxShowPassword.TabIndex = 2;
            cbxShowPassword.Text = "نمایش رمز";
            cbxShowPassword.UseVisualStyleBackColor = false;
            cbxShowPassword.CheckedChanged += cbxShowPassword_CheckedChanged;
            // 
            // lblUserAndIP
            // 
            lblUserAndIP.AutoSize = true;
            lblUserAndIP.BackColor = Color.Transparent;
            lblUserAndIP.Location = new Point(21, 200);
            lblUserAndIP.Name = "lblUserAndIP";
            lblUserAndIP.Size = new Size(75, 16);
            lblUserAndIP.TabIndex = 9;
            lblUserAndIP.Text = "10.16.192.1";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Maldives;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(446, 225);
            Controls.Add(lblUserAndIP);
            Controls.Add(cbxShowPassword);
            Controls.Add(lblChangePassword);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblChangePassword;
        private CheckBox cbxShowPassword;
        private Label lblUserAndIP;
    }
}