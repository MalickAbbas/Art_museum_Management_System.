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
    public partial class Exhibition : Form
    {
        public Exhibition()
        {
            InitializeComponent();
        }

        abstract class ADD
        {
            public void add()
            {
                MessageBox.Show("added Successfully");
            }
        }




        class display : ADD
        {

        }
        string name="";
        DateTime StartDate;
        DateTime EndDate;
        public class Exibition
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

            private string Name;
            private DateTime StartDate;
            private DateTime EndDate;
            public Exibition(string name , DateTime startdate , DateTime enddate)
            {
                this.Name = name;
                this.StartDate = startdate;
                this.EndDate = enddate;
            }
            public void addExibition()
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
                commands.CommandText = "INSERT into Exibition (Name,StartDate,EndDate) VALUES ('" + Name + "','" + StartDate + "','" + EndDate + "')";


                Console.WriteLine(StartDate);
                commands.ExecuteNonQuery();
                MessageBox.Show("SuccessFully Updated");

                connection.Close();

            }

        }

        private void Exhibition_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            StartDate = dateTimePicker1.Value.Date;
            EndDate = dateTimePicker2.Value.Date;

            Exibition sample = new Exibition(name, StartDate, EndDate);
            sample.addExibition();
            AddMenu set = new AddMenu();
            this.Dispose();
            set.Show();
        }
    }
}
