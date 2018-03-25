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

namespace Event_Scoring
{
    public partial class ContestntSettings : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        DataTable table = new DataTable();
           
        public ContestntSettings()
        {
            InitializeComponent();
            ContestantList.MultiSelect = false;
            ContestantList.GridLines = true;
            groupbox.Enabled = false;
            AllContestant();
            buttonsave.Enabled = false;
            buttondelete.Enabled = false;
            buttonupdate.Enabled = false;
           
        }
        public string GetConnectionString()
        {
            string connString = "SERVER=localhost;" +
                                "PORT=3306;" +
                                "DATABASE=event_scoring;" +
                                "USERNAME=root;" +
                                "PASSWORD=claveria;";
            return connString;
        }

        public MySqlConnection OpenConnection()
        {
            try
            {
                if (connection == null)
                    connection = new MySqlConnection(GetConnectionString());
                    connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public string cntsnt_id, cntsnt_number, cntsnt_fullname, cntsnt_address, cntsnt_talent, cntsnt_photopath;
        public static string clearlist;
        public static string select, select1, select2, select3, select4,select5;
        string listcntstnt_id;
        string pathimage;
        string donepath;


        private void Form6_Load(object sender, EventArgs e)
        {
        }

        public void AllContestant()
        {
            ContestantList.Items.Clear();
            table.Clear();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM event_scoring.tbl_contestant;", OpenConnection());
            CloseConnection();
            adapter.Fill(table);

            foreach (DataRow r in table.Rows)
            {
                cntsnt_id = r[0].ToString();
                cntsnt_number = r[1].ToString();
                cntsnt_fullname = r[2].ToString();
                cntsnt_address = r[3].ToString();
                cntsnt_talent = r[4].ToString();
                cntsnt_photopath = r[5].ToString();

                ListViewItem item = new ListViewItem(cntsnt_id);
                item.SubItems.Add(cntsnt_number);
                item.SubItems.Add(cntsnt_fullname);
                item.SubItems.Add(cntsnt_address);
                item.SubItems.Add(cntsnt_talent);
                item.SubItems.Add(cntsnt_photopath);
                ContestantList.Items.Add(item);
            }
        }

        private void ContestantList_Click(object sender, EventArgs e)
        {
               lblwarning.Visible = false;
               buttondelete.Enabled = true;
               buttonupdate.Enabled = true;    
               select = ContestantList.FocusedItem.SubItems[0].Text;
               select1 = ContestantList.FocusedItem.SubItems[1].Text;
               select2 = ContestantList.FocusedItem.SubItems[2].Text;
               select3 = ContestantList.FocusedItem.SubItems[3].Text;
               select4 = ContestantList.FocusedItem.SubItems[4].Text;
               select5 = ContestantList.FocusedItem.SubItems[5].Text;
                listcntstnt_id =select;
                textbox3.Text = select1;
                textbox.Text = select2;
                textbox1.Text = select3;
                textbox2.Text = select4;
                donepath = select5;
                picturebox.ImageLocation = select5;
                
        }
        public static string temppath;
        public void UpdateButton(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        public void UpdateContestant()
        {
            if (select4.Contains("\\"))
            {
                donepath = select4.Replace("\\", "\\\\");
                picturebox.ImageLocation = donepath;
            }
            string q = "UPDATE `event_scoring`.`tbl_contestant` SET `contestant_number`='" + textbox3.Text + "', `contestant_fullname`='" + textbox.Text +
                        "', `contestant_address`='" + textbox1.Text + "', `contestant_talent`='" + textbox2.Text +
                        "', `contestant_photopath`='" + donepath +"'WHERE `contestant_id`='" + select + "';";

            cmd = new MySqlCommand(q, OpenConnection());
            cmd.ExecuteNonQuery();
            CloseConnection();
            ContestantList.Items.Clear();
            AllContestant();
        }

        public void CreateContestant()
        {
            try
            {
              
                    cmd = new MySqlCommand("CreateContestant", OpenConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?contestant_number", textbox3.Text));
                    cmd.Parameters.Add(new MySqlParameter("?contestant_fullname", textbox.Text));
                    cmd.Parameters.Add(new MySqlParameter("?contestant_address", textbox1.Text));
                    cmd.Parameters.Add(new MySqlParameter("?contestant_talent", textbox2.Text));
                    cmd.Parameters.Add(new MySqlParameter("?contestant_photopath", donepath));
                    cmd.Parameters.Add(new MySqlParameter("?contestant_statusview", Application.StartupPath + "\\exis.png"));
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void BrowseImage()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "JPG files|*.jpg|PNG files|*.png";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                pathimage = dlg.FileName;
                MessageBox.Show(pathimage);
                if (pathimage.Contains("\\"))
                {
                    donepath = pathimage.ToString().Replace("\\", "\\\\");
                    picturebox.ImageLocation = donepath;
                }

            }
            else { }
            select4 = donepath;
        }

        private void buttonchange_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            OpenConnection();
            string q = "DELETE FROM `event_scoring`.`tbl_contestant` WHERE `contestant_id`='" + select + "';";
            cmd = new MySqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            CloseConnection();
            ContestantList.Items.Clear();
            lblwarning.Text = "Delete Success !.";
            lblwarning.Visible = true;
            buttondelete.Enabled = false;
            buttonupdate.Enabled = false;
            textbox.Text = "";
            textbox1.Text = "";
            textbox2.Text = "";
            donepath = "";
            picturebox.ImageLocation = "";
            AllContestant();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            buttonupdate.Enabled = false;
            groupbox.Text = "Updating Contestant";
            groupbox.Enabled = true;
            buttonsave.Enabled = true;
            buttondelete.Enabled = false;
            buttoncreate.Enabled = false;
            buttonsave.Text ="Update Contestant";
        }
         private void buttoncreate_Click(object sender, EventArgs e)
         {
             buttoncreate.Enabled = false;
             groupbox.Text = "Creating Contestant"; 
             groupbox.Enabled = true;
             buttonsave.Enabled = true;
             buttondelete.Enabled = false;
             buttonupdate.Enabled = false;
             buttonsave.Text = "Create Contestant";

         }

         private void picturebox_Click(object sender, EventArgs e)
         {
             BrowseImage();
         }

         private void button1_Click(object sender, EventArgs e)
         {
             if (groupbox.Text == "Creating Contestant")
             {
                 if ((donepath == "") || (textbox.Text == "") || (textbox1.Text == "") || (textbox2.Text == "") || (textbox3.Text == ""))
                 {
                     lblwarning.Text = "Please complete the requirements";
                     lblwarning.Visible = true;
                 }
                 else
                 {
                     if (DialogResult.Yes == MessageBox.Show("Do you want to add this contestant?", "Creating Contestant", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                     {
                         lblwarning.Text = "Create Success !.";
                         lblwarning.Visible = true;
                         CreateContestant();
                         groupbox.Text = "Status";
                         groupbox.Enabled = false;
                         buttonsave.Enabled = false;
                         buttonsave.Text = "Save";
                         buttoncreate.Enabled = true;
                         buttoncreate.Enabled = true;
                     }
                 }
                     CloseConnection();
                     ContestantList.Items.Clear();
                     AllContestant();            
             }
             else if (groupbox.Text == "Updating Contestant")
             {
                 if ((donepath == " ") || (textbox.Text == " ") || (textbox1.Text == " ") || (textbox2.Text == " ") || (textbox3.Text == " "))
                 {
                     lblwarning.Text = "Please complete the requirements";
                     lblwarning.Visible = true;
                 }
                 else if ((donepath != " ") || (textbox.Text != " ") || (textbox1.Text != " ") || (textbox2.Text != " "))
                 {
                     if (DialogResult.Yes == MessageBox.Show("Do you want to update this contestant?", "Updating Contestant", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                     {
                         buttonupdate.Enabled = true;
                         lblwarning.Text = "Update Success !.";
                         lblwarning.Visible = true;
                         UpdateContestant();
                         groupbox.Text = "Status";
                         groupbox.Enabled = false;
                         buttonsave.Enabled = false;
                         buttonsave.Text = "Save";
                         buttoncreate.Enabled = true;
                     }
                     else { }
                     ContestantList.Items.Clear();
                     CloseConnection();                    
                     AllContestant();

                 }
             }
         }
         private void ContestantList_SelectedIndexChanged(object sender, EventArgs e)
         {}

         private void textbox_TextChanged(object sender, EventArgs e)
         {lblwarning.Visible = false;}
    }
            
}
