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
    public partial class Artmovement : Form
    {
        public Artmovement()
        {
            InitializeComponent();
        }

        interface movement
        {
            void addart();
        }
        string Names;
        int Year;
        string Description;


        class addmovement : movement
        {
            public void addart()
            {
                //............

            }
        }
        public class artmovement
        {
            private string Name;
            private int Year;
            private string Description;
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

            public artmovement(string name, int year , string description)
            {
                this.Name = name;
                this.Year = year;
                this.Description = description;
            }

            public void movementAdd()
            {
                //step 1 Create SQL Connection

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand();
                commands.Connection = connection;



                // step 3 run quesries



                commands.CommandType = CommandType.Text;
                commands.CommandText = "INSERT into ArtMovement (Name,Year,Description) VALUES ('" + Name + "','" + Year + "','" + Description + "')";



                commands.ExecuteNonQuery();
                MessageBox.Show("SuccessFully Updated");

                connection.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Names = textBox1.Text;
            Year = Convert.ToInt32(textBox2.Text);
            Description = textBox3.Text;

            artmovement sample = new artmovement(Names, Year, Description);
            sample.movementAdd();
            AddMenu set = new AddMenu();
            this.Dispose();
            set.Show();
        }
    }
}
