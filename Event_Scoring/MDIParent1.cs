using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Event_Scoring
{
    public partial class MainFormEvent : Form
    {

        public MainFormEvent()
        {
            InitializeComponent();
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
}     

        private void label2_Click(object sender, EventArgs e)
        {
            ExitForm ef = new ExitForm();
            ef.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainFormEvent_Load(object sender, EventArgs e)
        {
            this.AutoScroll = false;
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {


        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void judgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddConstestant fr4 = new AddConstestant();
            fr4.MdiParent = this;
            fr4.Show();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContestntSettings fr6 = new ContestntSettings();
            fr6.MdiParent = this;
            fr6.Show();
            fr6.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void judgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
              Form5 fr5 = new Form5();
                fr5.MdiParent = this;
                fr5.Show();
        }
        Form5 fr5;
        private void judgeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AddJudge aj = new AddJudge();
            aj.MdiParent = this;
            aj.Show();
        }

        private void criteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criteriaToolStripMenuItem.Enabled = false;
            Form7 fr7 = new Form7();
            fr7.MdiParent = this;
            fr7.Show();
        }

        private void judgeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr5 = new Form5();
            fr5.MdiParent = this;
            fr5.Show();
        }

        private void contestantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContestntSettings contestantsettingd = new ContestntSettings();
            contestantsettingd.MdiParent = this;
            contestantsettingd.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void judgeViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void scoreViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.MdiParent = this;
            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExitForm ef = new ExitForm();
            ef.ShowDialog();
        }
    }
}
