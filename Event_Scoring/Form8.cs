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
    public partial class Form8 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();

        public Form8()
        {
            InitializeComponent();
            AllDetails();

            //PopulateContestant();
            //PopulateCriteria();
            //PopulateScore();
            //PopulateJudges();
            //SetUpListView();
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
            //try
            //{
                if (connection == null)
                    connection = new MySqlConnection(GetConnectionString());
                connection.Open();
                return connection;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //    return null;
            //}
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void AllDetails()
        {
            List<string> ContestantID = new List<string>();

            //SELECT c.criteria_name,s.scoring_criteriaavg,p.contestant_fullname FROM event_scoring.tbl_scoring s INNER JOIN tbl_criteria c 
            //ON c.criteria_id = s.criteria_id INNER JOIN tbl_contestant p ON s.contestant_id = p.contestant_id WHERE p.contestant_id= 1;

            //adapt = new MySqlDataAdapter("SELECT contestant_id, FROM tbl_contestant", OpenConnection());
            //adapt.Fill(table);
            //CloseConnection();
            //foreach (DataRow dt in table.Rows)
            //{

            //    ContestantID.Add(dt[0].ToString());

            //}


            int counter = 1;
            
            string q = "SELECT p.contestant_id, p.contestant_fullname, c.criteria_name FROM tbl_scoring s INNER JOIN " +
                        " tbl_criteria c ON c.criteria_id = s.criteria_id INNER JOIN tbl_contestant p ON" +
                        " s.contestant_id = p.contestant_id WHERE s.judge_id= " + 1 + ";";
            adapt = new MySqlDataAdapter(q, OpenConnection());
            DataTable dt1 = new DataTable();
            adapt.Fill(dt1);
            CloseConnection();
            List<string> fullname = new List<string>();
            
            List<string> id1 = new List<string>();
            listView1.Columns.Add("ContestantID");
            listView1.Columns.Add("FUll name");
            foreach (DataRow rd in dt1.Rows)
            {
                fullname.Add(rd["contestant_fullname"].ToString());
                id1.Add(rd["contestant_id"].ToString());
                listView1.Columns.Add(rd["criteria_name"].ToString());

            } listView1.Columns.Add("Total Score");
            for (int i = 0; i < 2; i++)
            {
                string qw = "SELECT c.criteria_name, p.contestant_fullname, s.scoring_criteriaavg FROM tbl_scoring s INNER JOIN " +
                            " tbl_criteria c ON c.criteria_id = s.criteria_id INNER JOIN tbl_contestant p ON" +
                            " s.contestant_id = p.contestant_id WHERE s.judge_id= " + 1 + ";";
                adapt = new MySqlDataAdapter(qw, OpenConnection());
                DataTable dt2 = new DataTable();

                adapt.Fill(dt2);
                CloseConnection();
                ListViewItem itm = new ListViewItem(id1[i]);
                itm.SubItems.Add(fullname[i]);
                foreach (DataRow rd in dt2.Rows)
                {
                    itm.SubItems.Add(rd["scoring_criteriaavg"].ToString());
                } listView1.Items.Add(itm);
                counter++;
            }

        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
