using LibraryData.Context;
using LibraryModel.Entities;
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
    public partial class FrmAddOrEditMember : Form
    {
        public int MemberId = 0;
        public FrmAddOrEditMember()
        {
            InitializeComponent();
        }

        private void FrmAddOrEditMember_Load(object sender, EventArgs e)
        {
            //pcMember.AllowDrop = true;
            //db = new UnitOfWork();
            //if (MemberId != 0)
            //{
            //    this.Text = "ویرایش شخص";
            //    btnAddMember.Text = "ویرایش";
            //    var member = db.MemberRepository.GetById(MemberId);
            //    txtFirstName.Text = member.FirstName;
            //    txtLastName.Text = member.LastName;
            //    txtEmail.Text = member.Email;
            //    txtMobile.Text = member.Phone;
            //    txtBeginDate.Text = member.MembershipDate;
            //    txtMemberNum.Text = (member.MemberNum).ToString();
            //    txtBeginDate.Text = member.BeginDate;
            //    txtNationalityCode.Text = member.NationalCode;
            //    txtBirthday.Text = member.BirthDate;
            //    cmbGenderId.SelectedItem = member.GenderID;
            //    cmbEducationLevelId.SelectedItem = member.EducationId;
            //    txtAddress.Text = member.Address;
            //    pcMember.ImageLocation = Application.StartupPath + "/MemberImage/" + member.PhotoMember;

        }

        private void btnAddPictureMember_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcMember.ImageLocation = openFile.FileName;
            }

        }

        private void btnAddOrEditMember_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePictureMember_Click(object sender, EventArgs e)
        {
            this.pcMember.Image = null;
        }

        private void pcMember_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image image = Image.FromFile(pic);
                pcMember.Image = image;
            }

        }
    }
}
