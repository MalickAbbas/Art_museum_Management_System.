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
    public partial class Showmenu : Form
    {
        public Showmenu()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";


        private void button6_Click(object sender, EventArgs e)
        {
            Museum m = new Museum();
            this.Dispose();
            m.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (temp == "Art Work")
            {
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from Artwork", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }
            }


            else if (temp == "Exibition")
            {
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from Exibition", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }
            }

            else if (temp == "Visitor")
            {
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from Visitor", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }
            }


            else if (temp == "Museum Staff")
            {
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from MuseumStaff", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }
            }

            else if (temp == "Art Movement")
            {
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from ArtMovement", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }
            }
        }
    }
}
