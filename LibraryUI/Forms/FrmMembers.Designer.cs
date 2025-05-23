namespace LibraryUI.Forms
{
    partial class FrmMembers
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
            toolStrip1 = new ToolStrip();
            btnAddMember = new ToolStripButton();
            btnDeleteMember = new ToolStripButton();
            btnEditMember = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            lblFilter = new ToolStripLabel();
            txtFilterMember = new ToolStripTextBox();
            statusStrip1 = new StatusStrip();
            btnBackToHome = new ToolStripDropDownButton();
            dgvMembers = new DataGridView();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddMember, btnDeleteMember, btnEditMember, toolStripButton2, lblFilter, txtFilterMember });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1382, 62);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddMember
            // 
            btnAddMember.Image = Properties.Resources._1371475930_filenew;
            btnAddMember.ImageScaling = ToolStripItemImageScaling.None;
            btnAddMember.ImageTransparentColor = Color.Magenta;
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(44, 59);
            btnAddMember.Text = "جدید";
            btnAddMember.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Image = Properties.Resources._1371476007_Close_Box_Red;
            btnDeleteMember.ImageScaling = ToolStripItemImageScaling.None;
            btnDeleteMember.ImageTransparentColor = Color.Magenta;
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(44, 59);
            btnDeleteMember.Text = "جدید";
            btnDeleteMember.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnEditMember
            // 
            btnEditMember.Image = Properties.Resources._1371475973_document_edit;
            btnEditMember.ImageScaling = ToolStripItemImageScaling.None;
            btnEditMember.ImageTransparentColor = Color.Magenta;
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new Size(44, 59);
            btnEditMember.Text = "جدید";
            btnEditMember.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditMember.Click += btnEditMember_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources._1371476342_Refresh;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(44, 59);
            toolStripButton2.Text = "جدید";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // lblFilter
            // 
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(41, 59);
            lblFilter.Text = "جستجو";
            lblFilter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFilterMember
            // 
            txtFilterMember.Name = "txtFilterMember";
            txtFilterMember.Size = new Size(100, 62);
            txtFilterMember.TextChanged += txtFilterMember_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { btnBackToHome });
            statusStrip1.Location = new Point(0, 721);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.No;
            statusStrip1.Size = new Size(1382, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // btnBackToHome
            // 
            btnBackToHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBackToHome.Image = Properties.Resources.Back_PNG_Photo;
            btnBackToHome.ImageTransparentColor = Color.Magenta;
            btnBackToHome.Name = "btnBackToHome";
            btnBackToHome.Size = new Size(29, 20);
            btnBackToHome.Text = "toolStripDropDownButton1";
            btnBackToHome.Click += btnBackToHome_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(0, 62);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.Size = new Size(1382, 659);
            dgvMembers.TabIndex = 3;
            // 
            // FrmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 743);
            Controls.Add(dgvMembers);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmMembers";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "اعضاء";
            Load += FrmMembers_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private DataGridView dgvMembers;
        private ToolStripButton btnAddMember;
        private ToolStripButton btnDeleteMember;
        private ToolStripButton btnEditMember;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel lblFilter;
        private ToolStripTextBox txtFilterMember;
        private ToolStripDropDownButton btnBackToHome;
    }
}