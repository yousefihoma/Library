namespace LibraryUI.Forms
{
    partial class FrmChangePass
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
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnChangePass = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxShowPass = new CheckBox();
            btnCancel = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbxShowVirtualKeyboard = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(227, 70);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(234, 23);
            txtNewPassword.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(227, 110);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(234, 23);
            txtConfirmPassword.TabIndex = 1;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(255, 192, 255);
            btnChangePass.ForeColor = Color.FromArgb(0, 0, 64);
            btnChangePass.Location = new Point(386, 202);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(75, 23);
            btnChangePass.TabIndex = 2;
            btnChangePass.Text = "ثبت";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(227, 30);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(234, 23);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(477, 33);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(477, 73);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "رمز عبور:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(477, 113);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "تکرار رمز عبور:";
            // 
            // cbxShowPass
            // 
            cbxShowPass.AutoSize = true;
            cbxShowPass.Location = new Point(380, 146);
            cbxShowPass.Name = "cbxShowPass";
            cbxShowPass.RightToLeft = RightToLeft.Yes;
            cbxShowPass.Size = new Size(77, 19);
            cbxShowPass.TabIndex = 7;
            cbxShowPass.Text = "نمایش رمز";
            cbxShowPass.UseVisualStyleBackColor = true;
            cbxShowPass.CheckedChanged += cbxShowPass_CheckedChanged;
            cbxShowPass.CheckStateChanged += cbxShowPass_CheckStateChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 255);
            btnCancel.ForeColor = Color.FromArgb(0, 0, 64);
            btnCancel.Location = new Point(243, 202);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "انصراف";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 258);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 35);
            label4.Name = "label4";
            label4.Size = new Size(162, 14);
            label4.TabIndex = 5;
            label4.Text = " رمز  عبور باید حداقل 8 کاراکتر ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(-14, 136);
            label8.Name = "label8";
            label8.Size = new Size(337, 15);
            label8.TabIndex = 5;
            label8.Text = "------------------------------------------------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(142, 196);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 5;
            label10.Text = "خودداری کنید";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(7, 173);
            label9.Name = "label9";
            label9.Size = new Size(206, 15);
            label9.TabIndex = 5;
            label9.Text = "لطفا از قرار دادن رمز خود در اختیار دیگران";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 99);
            label5.Name = "label5";
            label5.Size = new Size(158, 15);
            label5.TabIndex = 5;
            label5.Text = " یک عدد و یک کاراکتر ویژه باشد";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 66);
            label6.Name = "label6";
            label6.Size = new Size(203, 15);
            label6.TabIndex = 5;
            label6.Text = " انگلیسی و شامل حداقل یک حرف بزرگ و ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(169, 33);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(43, 20);
            label7.TabIndex = 5;
            label7.Text = "توجه:";
            // 
            // cbxShowVirtualKeyboard
            // 
            cbxShowVirtualKeyboard.AutoSize = true;
            cbxShowVirtualKeyboard.Location = new Point(239, 146);
            cbxShowVirtualKeyboard.Name = "cbxShowVirtualKeyboard";
            cbxShowVirtualKeyboard.RightToLeft = RightToLeft.Yes;
            cbxShowVirtualKeyboard.Size = new Size(113, 19);
            cbxShowVirtualKeyboard.TabIndex = 6;
            cbxShowVirtualKeyboard.Text = "صفحه کلید مجازی";
            cbxShowVirtualKeyboard.UseVisualStyleBackColor = true;
            // 
            // FrmChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            BackgroundImage = Properties.Resources.Maldives;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 237);
            Controls.Add(cbxShowVirtualKeyboard);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(cbxShowPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(btnChangePass);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChangePass";
            Load += frmChangePass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePass;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbxShowPass;
        private Button btnCancel;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label10;
        private Label label9;
        private CheckBox cbxShowVirtualKeyboard;
    }
}