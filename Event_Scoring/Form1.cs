using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Event_Scoring
{
    public partial class frm_login : Form
    {
        public static string connstring;
        MySqlConnection connection;
        MySqlCommand cmd;
       

        public frm_login()
        {
            InitializeComponent();
          
            connstring = "SERVER=localhost;PORT=3306;DATABASE=Event_Scoring;UID=root;PASSWORD=claveria;";
            connection = new MySqlConnection(connstring);
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "on")
            {
                button1.Text = "off";
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                button1.Text = "on";
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          

            if ((txt_username.Text == "") || (txt_password.Text == ""))
             label6.Visible = true; 
            else
            {
                try
                {
                    connection.Open();
                    string q = "SELECT * FROM tbl_users WHERE users_username='" + txt_username.Text +
                        "' AND users_password = '" + txt_password.Text + "';";
                    cmd = new MySqlCommand(q, connection);
                    MySqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            Form5.usertype = rd[4].ToString();
                            Scoring.judge_id_1 = rd[3].ToString();
                            if (rd[4].ToString() == "Judge")
                            {
                                
                                Form5 f5 = new Form5();
                                f5.ShowDialog();

                            }
                            else
                            {
                                MainFormEvent mf = new MainFormEvent();
                                mf.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        label6.Location = new Point(240, 226);
                        label6.Text = "No Account!."; label6.Visible = true;
                    }
                    connection.Close();
                        rd.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please  complete the requirements" + ex);
                }
                   
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            label6.Location = new Point(103, 226);
            label6.Text = "Please complete the requirements";
            label6.Visible = false;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            label6.Location = new Point(103, 226);
            label6.Text = "Please complete the requirements";
            label6.Visible = false;
        }
    }
}
