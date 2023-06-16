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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public string temp;

        private void button2_Click(object sender, EventArgs e)
        {
            FilterData det = new FilterData();
            this.Dispose();
            det.Show();
        }
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp == "Art Work")
            {

                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from Artwork where Title=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", textBox1.Text);
                SqlDataReader reader = commands.ExecuteReader();

                if (reader.HasRows)
                {
                    connection.Close();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(commands);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBox1.Text = " ";
                    connection.Close();
                }
            }




           else if (temp == "Exibition")
            {

                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from Exibition where Name=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", textBox1.Text);
                SqlDataReader reader = commands.ExecuteReader();

                if (reader.HasRows)
                {
                    connection.Close();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(commands);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBox1.Text = " ";
                    connection.Close();
                }
            }




            else if (temp == "Visitor")
            {

                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from Visitor where Name=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", textBox1.Text);
                SqlDataReader reader = commands.ExecuteReader();

                if (reader.HasRows)
                {
                    connection.Close();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(commands);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBox1.Text = " ";
                    connection.Close();
                }
            }



            else if (temp == "Museum Staff")
            {

                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from MuseumStaff where StaffName=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", textBox1.Text);
                SqlDataReader reader = commands.ExecuteReader();

                if (reader.HasRows)
                {
                    connection.Close();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(commands);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBox1.Text = " ";
                    connection.Close();
                }
            }


            else if (temp == "Art Movement")
            {

                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from ArtMovement where Name=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", textBox1.Text);
                SqlDataReader reader = commands.ExecuteReader();

                if (reader.HasRows)
                {
                    connection.Close();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(commands);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBox1.Text = " ";
                    connection.Close();
                }
            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           temp = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
