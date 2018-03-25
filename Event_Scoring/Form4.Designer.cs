namespace Event_Scoring
{
    partial class AddJudge
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
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.txtjudgename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblwarning = new System.Windows.Forms.Label();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.txtjudgename);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Location = new System.Drawing.Point(12, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(390, 117);
            this.groupbox.TabIndex = 6;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Status";
            // 
            // txtjudgename
            // 
            this.txtjudgename.Location = new System.Drawing.Point(6, 65);
            this.txtjudgename.Name = "txtjudgename";
            this.txtjudgename.Size = new System.Drawing.Size(370, 23);
            this.txtjudgename.TabIndex = 2;
            this.txtjudgename.TextChanged += new System.EventHandler(this.txtjudgename_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Judge Name :";
            // 
            // buttonsave
            // 
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsave.Location = new System.Drawing.Point(15, 221);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(386, 40);
            this.buttonsave.TabIndex = 15;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttoncreate
            // 
            this.buttoncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncreate.Location = new System.Drawing.Point(143, 175);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(116, 40);
            this.buttoncreate.TabIndex = 17;
            this.buttoncreate.Text = "Create";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Location = new System.Drawing.Point(265, 175);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(116, 40);
            this.buttondelete.TabIndex = 18;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(407, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 240);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judge Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 208;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(18, 141);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(168, 21);
            this.lblwarning.TabIndex = 20;
            this.lblwarning.Text = " Deletion Success !.";
            this.lblwarning.Visible = false;
            // 
            // buttonupdate
            // 
            this.buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdate.Location = new System.Drawing.Point(21, 175);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(116, 40);
            this.buttonupdate.TabIndex = 16;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // AddJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 278);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.groupbox);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddJudge";
            this.Text = "Settings (Judge)";
            this.Load += new System.EventHandler(this.AddJudge_Load_1);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.TextBox txtjudgename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Button buttonupdate;
    }
}