using LibraryData.Context;
using LibraryData.Services;
using LibraryModel;
using LibraryUtility;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FrmChangePass : Form
    {
        public string UserName;
        public FrmChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // try-catch نباشد؟
            (txtNewPassword.Text).CheckPasswordStrength();
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                //RtlMessageBox.Show("رمز با تکرار رمز برابر نیست", "توجه");
            }
            else
            {
                //Hass pass     
                //>??????
                UserRepository db = new UserRepository(new LibraryContext());
                //??????/ db.GetAllAsQueryable
                var user = db.GetAll().FirstOrDefault(r => r.UserName.Trim().ToLower() == txtUserName.Text.Trim().ToLower());
                if (user == null)
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا");

                }
                else
                {
                    user.UserName = txtUserName.Text;
                    user.Password = txtNewPassword.Text;
                    db.Save();
                    //RtlMessageBox.Show("رمز با موفقیت تغییر کرد");
                    Close();
                }

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUserName.Text = UserName;
            //Design.AnimateWindow(this.Handle, 1000, Design.HOR_NEGATIVE);
        }

        private void cbxShowPass_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }
    }


}

 


     
 
