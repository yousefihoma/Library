namespace LibraryUI.Forms
{
    partial class FrmAddOrEditMember
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
            pcMember = new PictureBox();
            btnAddPictureMember = new Button();
            btnAddOrEditMember = new Button();
            btnDeletePictureMember = new Button();
            ((System.ComponentModel.ISupportInitialize)pcMember).BeginInit();
            SuspendLayout();
            // 
            // pcMember
            // 
            pcMember.Location = new Point(575, 76);
            pcMember.Name = "pcMember";
            pcMember.Size = new Size(186, 208);
            pcMember.TabIndex = 0;
            pcMember.TabStop = false;
            pcMember.DragDrop += pcMember_DragDrop;
            // 
            // btnAddPictureMember
            // 
            btnAddPictureMember.Location = new Point(575, 298);
            btnAddPictureMember.Name = "btnAddPictureMember";
            btnAddPictureMember.Size = new Size(75, 23);
            btnAddPictureMember.TabIndex = 1;
            btnAddPictureMember.Text = "button1";
            btnAddPictureMember.UseVisualStyleBackColor = true;
            btnAddPictureMember.Click += btnAddPictureMember_Click;
            // 
            // btnAddOrEditMember
            // 
            btnAddOrEditMember.Location = new Point(380, 342);
            btnAddOrEditMember.Name = "btnAddOrEditMember";
            btnAddOrEditMember.Size = new Size(75, 23);
            btnAddOrEditMember.TabIndex = 2;
            btnAddOrEditMember.Text = "button1";
            btnAddOrEditMember.UseVisualStyleBackColor = true;
            btnAddOrEditMember.Click += btnAddOrEditMember_Click;
            // 
            // btnDeletePictureMember
            // 
            btnDeletePictureMember.Location = new Point(686, 298);
            btnDeletePictureMember.Name = "btnDeletePictureMember";
            btnDeletePictureMember.Size = new Size(75, 23);
            btnDeletePictureMember.TabIndex = 3;
            btnDeletePictureMember.Text = "button1";
            btnDeletePictureMember.UseVisualStyleBackColor = true;
            btnDeletePictureMember.Click += btnDeletePictureMember_Click;
            // 
            // FrmAddOrEditMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletePictureMember);
            Controls.Add(btnAddOrEditMember);
            Controls.Add(btnAddPictureMember);
            Controls.Add(pcMember);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAddOrEditMember";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "FrmAddOrEditMember";
            Load += FrmAddOrEditMember_Load;
            ((System.ComponentModel.ISupportInitialize)pcMember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcMember;
        private Button btnAddPictureMember;
        private Button btnAddOrEditMember;
        private Button btnDeletePictureMember;
    }
}