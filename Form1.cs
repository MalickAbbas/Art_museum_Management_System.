using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Museum_Catalog_of_art_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string title="";
        public string artist="";
        public string medium="";
        public class Artwork
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

            private string Title;
            private string Artist;
            private string Medium;

            public string tittle
            {
                get { return Title; }
                set { Title = value; }
            }
            public Artwork(string title , string artist , string medium)
            {
                this.Title = title;
                this.Artist = artist;
                this.Medium = medium;
            }
            
            public void ADD()
            {
                //Console.WriteLine(Title);
                //step 1 Create SQL Connection

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand();
                commands.Connection = connection;
               


                // step 3 run quesries



                commands.CommandType = CommandType.Text;
                commands.CommandText = "INSERT into Artwork (Title,Artist,Medium) VALUES ('" + Title + "','" + Artist + "','" + Medium +  "')";



                commands.ExecuteNonQuery();
                MessageBox.Show("SuccessFully Updated");
                
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            title = textBox1.Text;
            artist = textBox2.Text;
            medium = textBox3.Text;
        

            Artwork sample = new Artwork(title, artist, medium);
            sample.ADD();
            AddMenu set = new AddMenu();
            this.Dispose();
            set.Show();
        }
    }
}
