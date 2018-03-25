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
    public partial class AddConstestant : Form
    {
        public static string connstring;
        MySqlConnection connection;
        MySqlCommand cmd;
         
        public AddConstestant()
        {
            InitializeComponent();
            GenerateControls();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.Manual;
            connstring = "SERVER=localhost;PORT=3306;DATABASE=Event_Scoring;UID=root;PASSWORD=claveria;";
            connection = new MySqlConnection(connstring);
        }

        string pathimage;
        string donepath;
        public static PictureBox picturebox;
        public static TextBox textbox;
        public static TextBox textbox1;
        public static TextBox textbox2;
        string cntsntname;
        string address;
        int padding = 15;

        private void AddConstestant_Load(object sender, EventArgs e)
        {
            
        }

        public Label GenerateLabel(int px, int py, string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(px, py);
            label.Size = new Size(250, 30);
            label.Font = new Font("Century Gothic", 11);
            return label;
        }

        public Button GenerateButton(int px, int py, string text)
        {
            Button button = new Button();
            button.Size = new Size(410, 50);
            button.Location = new Point(px,py);
            button.Text = text;
            button.FlatStyle = FlatStyle.Flat;
            return button;
        }

        public PictureBox GeneratePictureBox(int px, int py)
        {
            picturebox = new PictureBox();
            picturebox.Size = new Size(410, 300);
            picturebox.Location = new Point(px, py);
            if (pathimage == null) picturebox.ImageLocation = Application.StartupPath.ToString() +"\\noimage.png";
            else { picturebox.ImageLocation = pathimage; }

            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            return picturebox;
        }

        public TextBox GenerateTextBox(int px, int py)
        {
           TextBox textbox = new TextBox();
           
            textbox.Size = new Size(409, 30);
            textbox.Location = new Point(px, py);
            textbox.Font = new Font("Century Gothic",10);
            textbox.Text = Text;
            textbox.Clear();
            return textbox;
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

            PictureBox picture = GeneratePictureBox(6,6);
            
            Button button = GenerateButton(5,315, "Browse Image");
            button.Click += new EventHandler(FunctionButton);

            Label label = GenerateLabel(padding, 375, "Contestant Name");
            textbox = GenerateTextBox(5, 410);
            cntsntname = textbox.Text;

            Label label1 = GenerateLabel(padding, 450, "Address");
            textbox1 = GenerateTextBox(5, 480);
            address = textbox1.Text;

            Label label2 = GenerateLabel(padding, 520, "Talent");
            textbox2 = GenerateTextBox(5, 545);

                Button button1 = GenerateButton(5, 600, "Save");
                button1.Click += new EventHandler(FunctionButton);

                panel.Controls.Add(picture);
                panel.Controls.Add(button);
                panel.Controls.Add(textbox);
                panel.Controls.Add(label);
                panel.Controls.Add(textbox1);
                panel.Controls.Add(label1);
                panel.Controls.Add(label2);
                panel.Controls.Add(textbox2);
                panel.Controls.Add(button1);            
                  this.Controls.Add(panel);
        }

        public void FunctionButton(Object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "Browse Image") BrowseImage();
            else
            {
                if ((textbox.Text == "") || (textbox1.Text == "") || (textbox2.Text == "") || (donepath == ""))
                    MessageBox.Show("Please complete the details");
                else {Save();}
             }
        }
       public void BrowseImage()
        {    
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;

            dlg.Filter = "JPG files|*.jpg|PNG files|*.png";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathimage = dlg.FileName;
                string temppath = pathimage.ToString().Replace("\\", "\\\\");
                donepath = temppath;
                picturebox.ImageLocation = pathimage;
            }
            else { }
        }

        public void Save()
        {
            
            try
            {

                string q = "INSERT INTO `event_scoring`.`tbl_contestant`" +
                    "(`contestant_fullname`, `contestant_address`, `contestant_talent`, `contestant_photopath` , `contestant_statusview`)" +
                    "VALUES ('" + textbox.Text + "', '" + textbox1.Text +"', '"+textbox2.Text+ "', '" +donepath + "', '"+@Application.StartupPath+"\\\\exis.png');";
                cmd = new MySqlCommand(q, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success");
                
                connection.Close();
                textbox.Clear();
                textbox1.Clear();
                textbox2.Clear();
            }
            catch (Exception ex){MessageBox.Show(ex.ToString());}

        }

        private void Close1_Click(object sender, EventArgs e)
        {this.Close();}

        private void Minimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }
    }
}
