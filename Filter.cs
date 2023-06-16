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
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }
        public string var = "";
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            FilterData fil = new FilterData();
            this.Dispose();
            fil.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.GetItemText(comboBox1.SelectedItem);

            if(temp == "Staff Whose Position is Manager")
            {
                var = "Manager";
                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command
                
                SqlCommand commands = new SqlCommand("Select * from MuseumStaff where Position=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", var);
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
                    
                    connection.Close();
                }
            }
            else if(temp == "Visitor Who Is From Canada")
            {

                var = "Canada";
                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from Visitor where Address=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", var);
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

                    connection.Close();
                }

            }
            else if (temp == "Art Movement Starts in 2020")
            {
                var = "2020";
                //step 1 Create SQL Connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionstring;
                connection.Open();

                //step 2 Create sql command

                SqlCommand commands = new SqlCommand("Select * from ArtMovement where Year=@Title");
                commands.Connection = connection;
                commands.Parameters.AddWithValue("@Title", var);
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

                    connection.Close();
                }
            }
        }
    }
}
