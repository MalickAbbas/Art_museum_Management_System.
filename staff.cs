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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        
        string StaffName;
        string Position;
         string Phone;
        class museumStaff
        {
            private string StaffName;
            private string Position;
            private string Phone;

            public museumStaff(string staffname , string position , string phone )
            {
                this.StaffName = staffname;
                this.Position = position;
                this.Phone = phone;
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



            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

            public void staffAdd()
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
                commands.CommandText = "INSERT into MuseumStaff (StaffName,Position,Phone) VALUES ('" + StaffName + "','" + Position + "','" + Phone + "')";



                commands.ExecuteNonQuery();
                MessageBox.Show("SuccessFully Updated");

                connection.Close();

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StaffName = textBox1.Text;
            Position = textBox2.Text;
            Phone = textBox3.Text;

            museumStaff staff = new museumStaff(StaffName, Position, Phone);
            staff.staffAdd();
            AddMenu set = new AddMenu();
            this.Dispose();
            set.Show();

        }


        
    }
}
