namespace Event_Scoring
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want close this application.";
            // 
            // btn_yes
            // 
            this.btn_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yes.ForeColor = System.Drawing.Color.White;
            this.btn_yes.Location = new System.Drawing.Point(46, 67);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(87, 36);
            this.btn_yes.TabIndex = 9;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(161, 67);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(87, 36);
            this.btn_no.TabIndex = 10;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 55F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 110);
            this.label2.TabIndex = 11;
            this.label2.Text = "?";
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 140);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label label2;
    }
}