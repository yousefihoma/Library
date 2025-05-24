using LibraryData.Context;
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
    public partial class FrmMembers : Form
    {
        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {

            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            BindGrid();
        }
        public void BindGrid()
        {
            dgvMembers.AutoGenerateColumns = true;
            MemberRepository memberRepository = new MemberRepository(new LibraryContext());
            dgvMembers.DataSource = memberRepository.GetAll();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmAddOrEditMember frmAdd = new FrmAddOrEditMember();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                MemberRepository memberRepository = new MemberRepository(new LibraryContext());

                string name = dgvMembers.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه",MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int memberId = int.Parse(dgvMembers.CurrentRow.Cells[0].Value.ToString());
                    memberRepository.Delete(memberId);
                    memberRepository.Save();
                    BindGrid();

                }
            }
            else
            {
                   RtlMessageBox.Show("لطفا شخصی را انتخاب کنید");
            }

        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                int personId = int.Parse(dgvMembers.CurrentRow.Cells[0].Value.ToString());
                FrmAddOrEditMember frmAddOrEdit = new FrmAddOrEditMember();
                frmAddOrEdit.MemberId = personId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtFilterMember_TextChanged(object sender, EventArgs e)
        {
            string Parameter = txtFilterMember.Text;
            MemberRepository memberRepository = new MemberRepository(new LibraryContext());

            dgvMembers.DataSource = memberRepository.GetAll(f => f.FirstName.Contains(Parameter) ||
                f.LastName.Contains(Parameter) || f.Mobile.Contains(Parameter) || f.CurrentDate.Contains(Parameter)
                );

        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
             
            Close();
        }
    }
}
 
