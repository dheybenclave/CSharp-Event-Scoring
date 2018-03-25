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
    struct Scoring_struct
    {
        public Label judgeAverageScore;
    }

    public partial class Scoring : Form
    {
        
        MySqlConnection connection;
        MySqlCommand cmd;
        DataTable table = new DataTable();
        MySqlDataAdapter adapt; 

        public Scoring()
        {
            InitializeComponent();
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

        private Label total_score;
        public static string judge_id_1;
        public static string contestant_id_get;

        int padding = 15;
        int paddingx = 15;
        int paddingy = 15;

        List<Scoring_struct> scores = new List<Scoring_struct>();
        List<int> criteriaset = new List<int>();
        List<int> percentset = new List<int>();
        List<string> scoring = new List<string>();
        List<string> averagescore = new List<string>();
  

        public TextBox GenerateTextbox(string name, string text, int locX, int locY)
        {
            TextBox textBox = new TextBox();
            //textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //textBox.TextAlign = HorizontalAlignment.Right;
            textBox.Size = new System.Drawing.Size(200, 70);
            textBox.Font = new System.Drawing.Font("Century Gothic",10);
            textBox.Location = new System.Drawing.Point(locX, locY);
            textBox.Name = name;
            textBox.Text = text;

            textBox.TextChanged += new EventHandler(Compute_Score);
            return textBox;
        }

        public Label GenerateLabel(string name, string text, int locX, int locY)
        {
            Label label = new Label();
            label.Font = new System.Drawing.Font("Century Gothic",10);  label.Location = new System.Drawing.Point(locX, locY);
            label.Name = name;
            label.Size = new System.Drawing.Size(250, 70);
            label.Text = text;
            label.TextAlign = ContentAlignment.TopRight;
            return label;

        }
        public Label GenerateLabel1(string name, string text, int locX, int locY)
        {
            Label label = new Label();
            label.Font = new System.Drawing.Font("Century Gothic", 12,FontStyle.Bold);
            label.Location = new System.Drawing.Point(locX, locY);
            label.Name = name;
            label.Size = new System.Drawing.Size(180, 70);
            label.Text = text;
            label.ForeColor = Color.Red;
            label.TextAlign = ContentAlignment.TopLeft;

            label.BringToFront();
            return label;

        }
        public void NumbersOnly(ref object sender, ref KeyPressEventArgs e, bool withDecPoint)
        {
            if (withDecPoint)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    e.Handled = true;
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        public void CheckScore(object sender, KeyPressEventArgs e)
        {
            NumbersOnly(ref sender, ref e, true);

        }

        private void Compute_Score(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            try
            {

                int index = Convert.ToInt32(t.Name.Split(new char[] { '_' })[1]);

                Scoring_struct s = scores[index - 1];
                double score1 = Convert.ToDouble(t.Text);
                double percentage1 = percentset[index - 1];
                Label l = s.judgeAverageScore;
                scoring.Insert(index - 1, score1.ToString());
                string percent1 = Convert.ToString(percentage1);
                string new1 = "";
                if(percent1.Length == 2)
                {

                    new1= "." + percentage1;
                }

                else if (percent1.Length == 1)
                {
                     new1 = ".0" + percentage1;
                }
                double final1 = score1 * Convert.ToDouble(new1);
                if (final1 <= percentage1)
                {
                    l.Text = final1.ToString();
                    s.judgeAverageScore.Text = l.Text;
                    averagescore.Insert(index - 1, l.Text);

                }
                else
                {
                    l.Text = "0";
                    t.Text = "0";
                }
            }
            catch (Exception ex)
            {
                //t.Text = "0";
                //MessageBox.Show(ex.ToString());
            }
        }


        public void GenerateObjects()
        {
            
            DataTable dt = new DataTable();
            dt.Clear();
            adapt = new MySqlDataAdapter("SELECT * FROM tbl_criteria ORDER BY criteria_percentage DESC ", OpenConnection());
            CloseConnection();
            adapt.Fill(dt);
            int counter = 1;
            foreach (DataRow row in dt.Rows)
            {
                Scoring_struct structscore = new Scoring_struct();
         
                criteriaset.Add(Convert.ToInt32(row["criteria_id"]));
                percentset.Add(Convert.ToInt32(row["criteria_percentage"]));

                panel1.Controls.Add(GenerateLabel1("criteriname_" + counter, row["criteria_name"].ToString(), paddingx + 5, paddingy + 10));
               
                Label label = GenerateLabel1("average_" + counter,  "0", 700, paddingy + 10);
              
                TextBox textbox = GenerateTextbox("textbox_" + counter, "0", 390, paddingy + 10);
                textbox.KeyPress += new KeyPressEventHandler(CheckScore);

                panel1.Controls.Add(GenerateLabel("percentage_" + counter , row["criteria_percentage"].ToString() + " %", paddingx + 70, paddingy + 10));
                

                panel1.Controls.Add(textbox);
                panel1.Controls.Add(label);
                paddingy += padding + 65;

                structscore.judgeAverageScore = label;
                scores.Add(structscore);
                counter++;
            }

        }

        public void ContestantDetails()
        { 
            table.Clear();
            adapt = new MySqlDataAdapter("SELECT * FROM tbl_contestant where contestant_number =" +contestant_id_get+";", OpenConnection());
            CloseConnection();
            adapt.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                lblname.Text = row[2].ToString();
                lblnumber.Text = row[1].ToString();
                lbltalent.Text = row[4].ToString();
                lbladdress.Text = row[3].ToString();
                pictureBox1.BackgroundImage = new System.Drawing.Bitmap(row[5].ToString());
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
          

           
        }
        private void Scoring_Load(object sender, EventArgs e)
        {
            string a = lbladdress.Text.ToUpper();
            string n = lblname.Text = lblname.Text.ToUpper();
            string nu = lblnumber.Text = lblnumber.Text.ToUpper();
            string t = lbltalent.Text = lbltalent.Text.ToUpper();
            lblname.Text = n;
            lbladdress.Text = a;
            lblnumber.Text = nu;
            lbltalent.Text = t;
            ContestantDetails();
            GenerateObjects();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
  
            DialogResult res = MessageBox.Show("Save the score?", "Save Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < scores.Count; i++)
                {

                    string insert_query =
                    "INSERT INTO `event_scoring`.`tbl_scoring` (`judge_id`, `contestant_id`, `criteria_id`, `scoring_score`, `scoring_criteriaavg`)" +
                        " VALUES ('" + judge_id_1 + "', '" + contestant_id_get + "', '" + criteriaset[i] + "', '" + scoring[i] + "', '" + averagescore[i] + "');";
                 MySqlCommand   command = new MySqlCommand(insert_query, connection);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
