using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Scoring
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
           
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
