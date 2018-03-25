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
namespace Event_Scoring
{
    public partial class Form5 : Form
    {
         public static string usertype;
        public static string connstring;
        MySqlConnection connection;
        MySqlCommand cmd;

        MySqlDataAdapter adapt;
        DataTable dt = new DataTable();
        public Form5()
        {
            InitializeComponent();
            connstring = "SERVER=localhost;PORT=3306;DATABASE=Event_Scoring;UID=root;PASSWORD=claveria;";
            connection = new MySqlConnection(connstring);
        
            GenerateControls();
            this.Font = new Font("Century Gothic", 8);
        }
        int padding = 15;
        int paddingx = 15;
        int paddingy = 15;
        int width = 800;
        int height = 500;

        public static GroupBox groupbox;
        public static PictureBox ss;
        string cntstnt_id;
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public Label GenerateLabel(int px, int py, string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(px, py);
            label.Size = new Size(300,30);
            label.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            return label;
        }
        
        public Button GenerateButton(string text)
        {
            Button button = new Button();
            button.Size = new Size(width-50, 80);
            button.Location = new Point(10, height - 100);
            button.Font = new Font("Century Gothic", 10);
            button.Text = text;
            button.FlatStyle = FlatStyle.Flat;
           // button.BackColor = Color.DimGray;
            button.FlatAppearance.MouseDownBackColor = Color.Orange;
            button.FlatAppearance.MouseOverBackColor = Color.DimGray;

            button.SendToBack();
            return button;
        }

        public PictureBox GeneratePictureBox(int px, int py, string name)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Size = new Size(400,280);
            picturebox.Location = new Point(px,py);
            picturebox.BackColor = Color.White;
            picturebox.ImageLocation = name;
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            return picturebox;
        }

        public PictureBox Status(string ss)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Size = new Size(50, 45);
            picturebox.Location = new Point(width-80,17);
            picturebox.ImageLocation = ss;
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            return picturebox;
        }

        public GroupBox GenerateGroupBox(int px, int py, string title)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(px, py);
            groupBox.Size = new Size(width-20, height);
            groupBox.BackColor = Color.DimGray;
            groupBox.ForeColor = Color.White;
            groupBox.Text = title;
            return groupBox;
        }

        public void GenerateControls()
        {
            Panel panel = new Panel();
            panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right |
            System.Windows.Forms.AnchorStyles.Bottom)));
            panel.Location = new System.Drawing.Point(5, 5);
            panel.Size = new System.Drawing.Size(this.Width - 30, this.Height - 50);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.AutoScroll = true;
            int i = 1;
            try
            {
                connection.Open();
                string q = "SELECT * FROM event_scoring.tbl_contestant";
                cmd = new MySqlCommand(q, connection);
                MySqlDataReader rd;
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {

                    while (rd.Read())
                    {
                        cntstnt_id = rd[1].ToString();
                        groupbox = GenerateGroupBox(paddingx, paddingy, "Contestant # " + rd[1].ToString());
                        groupbox.Controls.Add(GenerateLabel(450, 80, "Contestant Name : " + rd[2].ToString()));
                        groupbox.Controls.Add(GenerateLabel(450, 140, "Address : " + rd[3].ToString()));
                        groupbox.Controls.Add(GenerateLabel(450, 180, "Talent : " + rd[4].ToString()));

                        PictureBox picturebox = GeneratePictureBox(25, 50, rd[5].ToString());
                        ss = Status(Application.StartupPath + "\\exis.png");
                        Button button = GenerateButton( "Your Score for Contestant No : " + cntstnt_id);
                        button.Click += new EventHandler(FunctionButton);

                        // button.MouseEnter += button_MouseEnter;
                        groupbox.Controls.Add(button);
                        groupbox.Controls.Add(picturebox);

                        groupbox.Controls.Add(ss);

                        panel.Controls.Add(groupbox);

                        paddingx += padding + width;

                        if (Convert.ToInt32(rd["contestant_number"]) % 2 == 0)
                        {
                            paddingx = padding;
                            paddingy += padding + height;
                        }

                        this.Controls.Add(panel);
                    }
                }
                rd.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        //void button_MouseEnter(object sender, EventArgs e)
        //{
        //    Button mbutton = (Button)sender;
        //    mbutton.BackColor =  Color.White;
        //}


        public void FunctionButton(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Button ibutton = (Button)sender;
                string temp  = ibutton.Text.Replace("Your Score for Contestant No : ","");
                Scoring.contestant_id_get = temp;
                Scoring sc = new Scoring();
                sc.ShowDialog();
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5 = null;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usertype == "Judge")
            {
                ExitForm ef = new ExitForm();
                ef.ShowDialog();
            }
            else if (usertype == "Admin")
            { 
}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
    