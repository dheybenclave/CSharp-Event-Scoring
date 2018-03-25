namespace Event_Scoring
{
    partial class ContestntSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContestntSettings));
            this.ContestantList = new System.Windows.Forms.ListView();
            this.contestant_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contestant_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contestant_fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contestant_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contestant_talent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contestant_photopath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonbrowseimage = new System.Windows.Forms.Button();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContestantList
            // 
            this.ContestantList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ContestantList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contestant_id,
            this.contestant_number,
            this.contestant_fullname,
            this.contestant_address,
            this.contestant_talent,
            this.contestant_photopath});
            this.ContestantList.FullRowSelect = true;
            this.ContestantList.GridLines = true;
            this.ContestantList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ContestantList.HoverSelection = true;
            this.ContestantList.Location = new System.Drawing.Point(12, 25);
            this.ContestantList.Name = "ContestantList";
            this.ContestantList.Size = new System.Drawing.Size(553, 553);
            this.ContestantList.TabIndex = 0;
            this.ContestantList.UseCompatibleStateImageBehavior = false;
            this.ContestantList.View = System.Windows.Forms.View.Details;
            this.ContestantList.SelectedIndexChanged += new System.EventHandler(this.ContestantList_SelectedIndexChanged);
            this.ContestantList.Click += new System.EventHandler(this.ContestantList_Click);
            // 
            // contestant_id
            // 
            this.contestant_id.Text = "id";
            this.contestant_id.Width = 0;
            // 
            // contestant_number
            // 
            this.contestant_number.Text = "No";
            this.contestant_number.Width = 30;
            // 
            // contestant_fullname
            // 
            this.contestant_fullname.Text = "Contestant Name";
            this.contestant_fullname.Width = 172;
            // 
            // contestant_address
            // 
            this.contestant_address.Text = "Address";
            this.contestant_address.Width = 199;
            // 
            // contestant_talent
            // 
            this.contestant_talent.Text = "Talent";
            this.contestant_talent.Width = 145;
            // 
            // contestant_photopath
            // 
            this.contestant_photopath.Text = "Photopath";
            this.contestant_photopath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.contestant_photopath.Width = 0;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.textbox3);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.buttonbrowseimage);
            this.groupbox.Controls.Add(this.textbox2);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.textbox1);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.textbox);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.picturebox);
            this.groupbox.Location = new System.Drawing.Point(575, 25);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(362, 419);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Status";
            this.groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(244, 383);
            this.textbox3.MaxLength = 2;
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(107, 23);
            this.textbox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contestant Number : ";
            // 
            // buttonbrowseimage
            // 
            this.buttonbrowseimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbrowseimage.Location = new System.Drawing.Point(189, 203);
            this.buttonbrowseimage.Name = "buttonbrowseimage";
            this.buttonbrowseimage.Size = new System.Drawing.Size(146, 40);
            this.buttonbrowseimage.TabIndex = 7;
            this.buttonbrowseimage.Text = "Browse Image";
            this.buttonbrowseimage.UseVisualStyleBackColor = true;
            this.buttonbrowseimage.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(11, 383);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(166, 23);
            this.textbox2.TabIndex = 6;
            this.textbox2.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contestant Talent :";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(11, 332);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(340, 23);
            this.textbox1.TabIndex = 4;
            this.textbox1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contestant Address :";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(11, 284);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(340, 23);
            this.textbox.TabIndex = 2;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contestant Name :";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturebox.BackgroundImage")));
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox.Location = new System.Drawing.Point(25, 22);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(310, 221);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdate.Location = new System.Drawing.Point(575, 488);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(116, 40);
            this.buttonupdate.TabIndex = 8;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Location = new System.Drawing.Point(819, 488);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(116, 40);
            this.buttondelete.TabIndex = 10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttoncreate
            // 
            this.buttoncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncreate.Location = new System.Drawing.Point(697, 488);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(116, 40);
            this.buttoncreate.TabIndex = 9;
            this.buttoncreate.Text = "Create";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsave.Location = new System.Drawing.Point(575, 534);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(360, 40);
            this.buttonsave.TabIndex = 11;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(579, 453);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(168, 21);
            this.lblwarning.TabIndex = 8;
            this.lblwarning.Text = " Deletion Success !.";
            this.lblwarning.Visible = false;
            // 
            // ContestntSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 590);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.ContestantList);
            this.Controls.Add(this.buttonupdate);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ContestntSettings";
            this.ShowInTaskbar = false;
            this.Text = "Settings (Contestant)";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ColumnHeader contestant_id;
        public System.Windows.Forms.ColumnHeader contestant_fullname;
        public System.Windows.Forms.ColumnHeader contestant_address;
        public System.Windows.Forms.ColumnHeader contestant_talent;
        public System.Windows.Forms.ColumnHeader contestant_photopath;
        public System.Windows.Forms.ListView ContestantList;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Button buttonbrowseimage;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader contestant_number;
    }
}