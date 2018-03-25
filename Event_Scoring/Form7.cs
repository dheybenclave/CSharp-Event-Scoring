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
    public partial class Form7 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        DataTable table = new DataTable();
       
        string select;
        string select1;
        string select2;
        string tip;
        string rp;
        public Form7()
        {
            
            InitializeComponent();
            listView1.FullRowSelect = true;
            PopulateRecords();
            totalpercentage();
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
        public void totalpercentage()
        {
            cmd = new MySqlCommand("SELECT  sum(criteria_percentage) AS 'totalinsertpercent' ,100-sum(criteria_percentage)  AS 'remainingpercent' FROM event_scoring.tbl_criteria;", OpenConnection());
           MySqlDataReader dr = cmd.ExecuteReader();
           if (dr.HasRows)
           {
               while (dr.Read())
               {
                   tip = dr["totalinsertpercent"].ToString();
                   rp = dr["remainingpercent"].ToString();
                   if (tip == "")
                   {
                       string temptip = "0";
                       tip = temptip;
                   }
                   if (rp == "")
                   {
                       string temprp = "100";
                       rp = temprp;
                   }
                   if (Convert.ToInt32(tip) == 100)
                   {
                       lblwarning.Text = "Your Criteria is Already 100%";
                       lblwarning.Visible = true;
                       buttoncreate.Enabled = false;
                   }
                   else
                   {
                       lblwarning.Visible = false;
                       buttoncreate.Enabled = true;
                   }

                   lbltotalinsertpercentage.Text = "Total Insert Percent : " + tip + " %";
                   lblremainingpercentage.Text = "Remaining Percent : " + rp + " %";
               }
           }
           else
           { }

         CloseConnection();
        }
    

        public void PopulateRecords()
        {
            listView1.Items.Clear();
            table.Clear();

            MySqlDataAdapter adapter =new MySqlDataAdapter("SELECT * FROM tbl_criteria ORDER BY criteria_percentage DESC", OpenConnection());
            CloseConnection();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                listView1.Items.Add(item);
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                     e.Handled = true;
        }

        public void SaveButton()
        {
            try
            {
              
                cmd = new MySqlCommand("SaveCriteria", OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?criteria_name", textBox1.Text));
                cmd.Parameters.Add(new MySqlParameter("?criteria_percentage",textBox2.Text));              
                cmd.ExecuteNonQuery();
                CloseConnection();
                PopulateRecords();
            }
            catch (Exception ex)
            {MessageBox.Show(ex.Message);}
        }
       

        private void Form7_Load(object sender, EventArgs e)
        {
            buttondelete.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void listView1_Click(object sender, EventArgs e)
        {

                groupBox1.Enabled = true;
                buttondelete.Enabled = true;
                select = listView1.FocusedItem.SubItems[0].Text;
                select1 = listView1.FocusedItem.SubItems[1].Text;
                select2 = listView1.FocusedItem.SubItems[2].Text;
                textBox1.Text = select1;
                textBox2.Text = select2;
            
        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox1.Text == " ") || (textBox2.Text == " "))
            {
                lblwarning.Text = "Please complete the requirements";
                lblwarning.Visible = true;
            }
            else
            {
                if (!(Convert.ToInt32(textBox2.Text) <= 100))
                {
                    lblwarning.Text = "The maximum value for percentage is 100 only ";
                    lblwarning.Visible = true;
                }
                else if (Convert.ToInt32(textBox2.Text) <= Convert.ToInt32(rp))
                {
                  
                    if ((Convert.ToInt32(tip) < 100) || (Convert.ToInt32(tip) <= 100))
                    {
                        totalpercentage();
                        SaveButton();
                        lblwarning.Text = "Adding Criteria Success !.";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        lblwarning.Visible = true;
                        groupBox1.Enabled = false;
                    }

                    else if (Convert.ToInt32(tip) > 100 || Convert.ToInt32(tip) == 100)
                    {
                        lblwarning.Text = "You reach the total percentage !.";
                        lblwarning.Visible = true;
                        totalpercentage();
                        buttoncreate.Enabled = false;
                    }
                    totalpercentage();
                }
                else {
                    lblwarning.Text = "Your Available percent is " + rp;
                    lblwarning.Visible = true;
                }
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Delete this criteria?. ", "Deleting Criteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                buttondelete.Enabled = false;
                OpenConnection();
                string q = "DELETE FROM `event_scoring`.`tbl_criteria` WHERE `criteria_id`='" + select + "';";
                cmd = new MySqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
                listView1.Items.Clear();
                lblwarning.Text = "Delete Success !.";
                lblwarning.Visible = true;
                buttondelete.Enabled = false;
                textBox1.Text = null;
                textBox2.Text = null;
                PopulateRecords();
                totalpercentage();
            }
            else 
            {
                textBox1.Text = null;
                textBox2.Text = null;
                lblwarning.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblwarning.Visible = false;

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToInt32(textBox2.Text) <= 100))
            {
                lblwarning.Text = "The maximum value for percentage is 100 only ";
                lblwarning.Visible = true;
            }
            else if (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(rp) <= 100 )
            {
                totalpercentage();
                if (DialogResult.Yes == MessageBox.Show("Do you want to update this contestant?", "Updating Contestant", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string q = "UPDATE `event_scoring`.`tbl_criteria` SET `criteria_name`='" + textBox1.Text +
                                "', `criteria_percentage`='" + textBox2.Text + "'WHERE `criteria_id`='" + select + "';";

                    cmd = new MySqlCommand(q, OpenConnection());
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    totalpercentage();
                    listView1.Items.Clear();
                    PopulateRecords();
                    lblwarning.Text = "Update Success !.";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    lblwarning.Visible = true;
                    groupBox1.Enabled = false;
                }
                lblwarning.Text = "Updating Criteria Success !.";
                lblwarning.Visible = true;
                groupBox1.Enabled = false;
            }
            else if (Convert.ToInt32(textBox2.Text) > 100 || Convert.ToInt32(textBox2.Text ) >= 100)
            {
                lblwarning.Text = "The available value for percentage is " + rp + " only ";
                lblwarning.Visible = true;
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttondelete_MouseDown(object sender, MouseEventArgs e)
        {

        }

       
    }
}
