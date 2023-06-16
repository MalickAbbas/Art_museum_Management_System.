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
    public partial class visitor : Form
    {
        public visitor()
        {
            InitializeComponent();
        }
        string NAME;
        int AGE;
        string ADDRESS;
        public class Visitor
        {
            private string Name;
            private int Age;
            private string Address;

            public string nammes
            {
                get { return Name; }
                set { Name = value; }
            }

            public Visitor(string name, int age ,string address)
            {
                this.Name = name;
                this.Age = age;
                this.Address = address;
            }

            public void Addvisitor()
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

                //step 1 Create SQL Connection

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand();
                commands.Connection = connection;



                // step 3 run quesries



                commands.CommandType = CommandType.Text;
                commands.CommandText = "INSERT into Visitor (Name,Age,Address) VALUES ('" + Name + "','" + Age + "','" + Address + "')";



                commands.ExecuteNonQuery();
                MessageBox.Show("SuccessFully Updated");

                connection.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAME = textBox1.Text;
            AGE = Convert.ToInt32(textBox2.Text);
            ADDRESS = textBox3.Text;

            Visitor sample = new Visitor(NAME, AGE, ADDRESS);
            sample.Addvisitor();
            AddMenu set = new AddMenu();
            this.Dispose();
            set.Show();

        }
    }
}
