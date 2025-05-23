 using LibraryUI.Forms;

namespace LibraryUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FrmLogin frmLogin = new FrmLogin();
            FrmLoading frmLoading = new FrmLoading();
            Application.Run( frmLogin);

            //if (frmLoading.DialogResult == DialogResult.OK)
            //{
            //    frmLogin.ShowDialog();
            //}
            //else if (frmLoading.DialogResult == DialogResult.Cancel)
            // { Application.Exit();
            //}

            if (frmLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }

    }
}
