using LibraryData.Context;
using LibraryModel;
using LibraryData.Services;
using LibraryModel.Entities;
using LibraryUI.Forms;

namespace LibraryUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int v = 10000000;
            lblAboutUs.Text = v.ToString("#,0");

        }


        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            plnSide.Top = lblReport.Top;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            plnSide.Top = lblExit.Top;
            Application.Exit();

        }

        private void lblFine_Click(object sender, EventArgs e)
        {
            plnSide.Top = lblFine.Top;
        }

        private void lblTempExit_Click(object sender, EventArgs e)
        {
            plnSide.Top = lblTempExit.Top;
            Application.Restart();

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            FrmMembers frmMembers = new FrmMembers();
            frmMembers.ShowDialog();
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            plnSide.Top = lblHistory.Top;

        }
    }
}
