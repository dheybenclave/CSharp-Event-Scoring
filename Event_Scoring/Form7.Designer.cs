namespace Event_Scoring
{
    partial class Form7
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.crtr_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crtr_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crtr_percentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblremainingpercentage = new System.Windows.Forms.Label();
            this.lbltotalinsertpercentage = new System.Windows.Forms.Label();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.crtr_id,
            this.crtr_name,
            this.crtr_percentage});
            this.listView1.Location = new System.Drawing.Point(399, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(482, 165);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // crtr_id
            // 
            this.crtr_id.Text = "Id";
            this.crtr_id.Width = 0;
            // 
            // crtr_name
            // 
            this.crtr_name.Text = "Criteria Name";
            this.crtr_name.Width = 337;
            // 
            // crtr_percentage
            // 
            this.crtr_percentage.Text = "Percentage";
            this.crtr_percentage.Width = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criteria Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 70);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Percentage (%) :";
            // 
            // lblremainingpercentage
            // 
            this.lblremainingpercentage.AutoSize = true;
            this.lblremainingpercentage.Location = new System.Drawing.Point(649, 189);
            this.lblremainingpercentage.Name = "lblremainingpercentage";
            this.lblremainingpercentage.Size = new System.Drawing.Size(176, 19);
            this.lblremainingpercentage.TabIndex = 8;
            this.lblremainingpercentage.Text = "Remaining Percentage :";
            // 
            // lbltotalinsertpercentage
            // 
            this.lbltotalinsertpercentage.AutoSize = true;
            this.lbltotalinsertpercentage.Location = new System.Drawing.Point(398, 189);
            this.lbltotalinsertpercentage.Name = "lbltotalinsertpercentage";
            this.lbltotalinsertpercentage.Size = new System.Drawing.Size(190, 19);
            this.lbltotalinsertpercentage.TabIndex = 9;
            this.lbltotalinsertpercentage.Text = "Total Insert of Percentage :";
            // 
            // buttoncreate
            // 
            this.buttoncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncreate.Location = new System.Drawing.Point(12, 126);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(169, 40);
            this.buttoncreate.TabIndex = 16;
            this.buttoncreate.Text = "Add";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Location = new System.Drawing.Point(199, 126);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(169, 40);
            this.buttondelete.TabIndex = 17;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            this.buttondelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttondelete_MouseDown);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(14, 189);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(294, 21);
            this.lblwarning.TabIndex = 18;
            this.lblwarning.Text = "You reach the total percentage !.";
            this.lblwarning.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 108);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.lbltotalinsertpercentage);
            this.Controls.Add(this.lblremainingpercentage);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form7";
            this.ShowInTaskbar = false;
            this.Text = "Settings (Criteria)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader crtr_name;
        private System.Windows.Forms.ColumnHeader crtr_percentage;
        private System.Windows.Forms.ColumnHeader crtr_id;
        private System.Windows.Forms.Label lblremainingpercentage;
        private System.Windows.Forms.Label lbltotalinsertpercentage;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}