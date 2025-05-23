using LibraryData.Services;
using LibraryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms
{
    public partial class FrmLogin : Form
    {
        UserRepository userRepository = new UserRepository(new LibraryContext());


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUserName.Text)) && (string.IsNullOrEmpty(txtPassword.Text)))
            {
                MessageBox.Show("لطفا نام کاربری و رمز عبور را وارد کنید");
            }

             
            UserRepository userRepository = new UserRepository(new LibraryContext());
            var user = userRepository.GetAll(u => u.UserName== txtUserName.Text && u.Password == txtPassword.Text && u.IsActive==true).FirstOrDefault();
            if (user != null)

            {
                //Program.CurrentUserId = user.UserID;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا");
            }
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUserName.Text)) || (string.IsNullOrWhiteSpace(txtUserName.Text)))
            {
                MessageBox.Show("لطفا نام کاربری را وارد کنید", "توجه");
            }
             else
            // {  // کد تکراری
                //var user = userRepository.GetAll(u => u.UserName == txtUserName.Text).FirstOrDefault();
                //if (user != null) 
                {
                    FrmChangePass frmChangePass = new FrmChangePass();
                    frmChangePass.UserName = txtUserName.Text;
                    frmChangePass.ShowDialog();
                }
            //}
        }
        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string UserName = Environment.UserName;
            //  string IP = Tools.GetLocalIP();
            //lblUserAndIP.Text = $"PC Name: {UserName}  IP: {IP}  ";
        }
    }
}
