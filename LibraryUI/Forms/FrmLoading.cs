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
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time != 2)
            {
                time += 1;
            }
            else
            {
                timer1.Enabled = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
