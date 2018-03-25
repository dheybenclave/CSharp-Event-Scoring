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
    public partial class AddJudge : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        DataTable table = new DataTable();
        string select;
        string select1;

        public AddJudge()
        {
            InitializeComponent();
            PopulateRecords();
        }

        private void AddJudge_Load(object sender, EventArgs e)
        {

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
                {
                    connection = new MySqlConnection(GetConnectionString());
                }
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

        public void PopulateRecords()
        {
            listView1.Items.Clear();
            table.Clear();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tbl_judge", OpenConnection());
            CloseConnection();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                listView1.Items.Add(item);
            }

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            lblwarning.Visible = true;
            string q = "DELETE FROM `event_scoring`.`tbl_judge` WHERE `judge_id`='" + select + "';";
            cmd = new MySqlCommand(q,OpenConnection());
            cmd.ExecuteNonQuery();
            CloseConnection();
            listView1.Items.Clear();
            PopulateRecords();
            txtjudgename.Text = "";

        
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            buttonupdate.Enabled = false;
            buttonsave.Text = "Update Judge";
            buttonsave.Enabled = true;
            groupbox.Text = "Updating Judge";
            groupbox.Enabled = true;
        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            buttoncreate.Enabled = false;
            buttonsave.Text = "Create Judge";
            buttonsave.Enabled = true;
            groupbox.Enabled = true;
            groupbox.Text = "Creating Judge";
           
        }

        private void txtjudgename_TextChanged(object sender, EventArgs e)
        {
            lblwarning.Visible = false;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            buttondelete.Enabled = true;
            buttonupdate.Enabled = true;
            select = listView1.FocusedItem.SubItems[0].Text;
            select1 = listView1.FocusedItem.SubItems[1].Text;
            txtjudgename.Text = select1;
        }
        public void CreateJudge()
        {
            try
            {

                cmd = new MySqlCommand("CreateJudge", OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?judgefullname", txtjudgename.Text));
                cmd.Parameters.Add(new MySqlParameter("?usertype", "Judge"));

                cmd.ExecuteNonQuery();
                CloseConnection();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void UpdateJudge()
        {
            string q = "UPDATE `event_scoring`.`tbl_judge` SET `judge_fullname`='" + txtjudgename.Text + "';" ;
            cmd = new MySqlCommand(q, OpenConnection());
            cmd.ExecuteNonQuery();
            CloseConnection();
            listView1.Items.Clear();
            PopulateRecords();

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            if (txtjudgename.Text == "" || txtjudgename.Text == " ")
            {
                lblwarning.Text = "Please fill the judge name !";
                lblwarning.Visible = true;
            }
            else if (groupbox.Text == "Creating Judge")
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to add this judge?", "Creating judge", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CreateJudge();
                    listView1.Items.Clear();
                    PopulateRecords();
                    buttonsave.Text = "Save";
                    buttonsave.Enabled = false;
                }
                else
                { }
            }
            else if (groupbox.Text == "Updating Judge")
            {
                UpdateJudge();
                listView1.Items.Clear();
                PopulateRecords();
                buttonsave.Text = "Save";
                buttonsave.Enabled = false;
            }
            else { }
        }

        private void AddJudge_Load_1(object sender, EventArgs e)
        {
            buttonsave.Enabled = false;
            groupbox.Enabled = false;
            buttondelete.Enabled = false;
            buttonupdate.Enabled = false;
        }
    }
}
