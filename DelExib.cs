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
    public partial class DelExib : Form
    {
        public DelExib()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            //step 1 Create SQL Connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionstring;
            connection.Open();

            //step 2 Create sql command

            SqlCommand commands = new SqlCommand("delete from Exibition where Name=@Name");
            commands.Connection = connection;
            commands.Parameters.AddWithValue("@Name", textBox1.Text);
            commands.ExecuteNonQuery();

            MessageBox.Show("Deleted Successfully");
            connection.Close();


            DeleteMenu del = new DeleteMenu();
            this.Dispose();
            del.Show();


        }
    }
}
