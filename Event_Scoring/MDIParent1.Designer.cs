namespace Event_Scoring
{
    partial class MainFormEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormEvent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.judgeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.judgeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contestantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Minimize = new System.Windows.Forms.Label();
            this.Close1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.judgeToolStripMenuItem1,
            this.contestantToolStripMenuItem1,
            this.criteriaToolStripMenuItem,
            this.scoreViewToolStripMenuItem,
            this.judgeViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // judgeViewToolStripMenuItem
            // 
            this.judgeViewToolStripMenuItem.Name = "judgeViewToolStripMenuItem";
            this.judgeViewToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.judgeViewToolStripMenuItem.Text = "Judge View";
            this.judgeViewToolStripMenuItem.Click += new System.EventHandler(this.judgeViewToolStripMenuItem_Click_1);
            // 
            // judgeToolStripMenuItem1
            // 
            this.judgeToolStripMenuItem1.Name = "judgeToolStripMenuItem1";
            this.judgeToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.judgeToolStripMenuItem1.Text = "Judge";
            this.judgeToolStripMenuItem1.Click += new System.EventHandler(this.judgeToolStripMenuItem1_Click_1);
            // 
            // contestantToolStripMenuItem1
            // 
            this.contestantToolStripMenuItem1.Name = "contestantToolStripMenuItem1";
            this.contestantToolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.contestantToolStripMenuItem1.Text = "Contestant";
            this.contestantToolStripMenuItem1.Click += new System.EventHandler(this.contestantToolStripMenuItem1_Click);
            // 
            // criteriaToolStripMenuItem
            // 
            this.criteriaToolStripMenuItem.Name = "criteriaToolStripMenuItem";
            this.criteriaToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.criteriaToolStripMenuItem.Text = "Criteria";
            this.criteriaToolStripMenuItem.Click += new System.EventHandler(this.criteriaToolStripMenuItem_Click);
            // 
            // scoreViewToolStripMenuItem
            // 
            this.scoreViewToolStripMenuItem.Name = "scoreViewToolStripMenuItem";
            this.scoreViewToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.scoreViewToolStripMenuItem.Text = "Score View";
            this.scoreViewToolStripMenuItem.Click += new System.EventHandler(this.scoreViewToolStripMenuItem_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.White;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Minimize.Location = new System.Drawing.Point(983, -12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 31);
            this.Minimize.TabIndex = 12;
            this.Minimize.Text = "_";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Minimize.Click += new System.EventHandler(this.label5_Click);
            // 
            // Close1
            // 
            this.Close1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close1.AutoSize = true;
            this.Close1.BackColor = System.Drawing.Color.White;
            this.Close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Close1.Location = new System.Drawing.Point(1025, -3);
            this.Close1.Name = "Close1";
            this.Close1.Size = new System.Drawing.Size(26, 31);
            this.Close1.TabIndex = 11;
            this.Close1.Text = "x";
            this.Close1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close1.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainFormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 715);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFormEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormEvent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormEvent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem judgeToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem contestantToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem criteriaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem judgeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreViewToolStripMenuItem;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Close1;

    }
}



