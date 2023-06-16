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
    public partial class DataSort : Form
    {
        public DataSort()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";

        private void button6_Click(object sender, EventArgs e)
        {
            Museum sum = new Museum();
            this.Dispose();
            sum.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.GetItemText(comboBox1.SelectedItem);
            if(temp == "Sort Art Movement By Year")
            {

                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from ArtMovement ORDER BY Year ASC", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }
            }

            else if (temp == "Sort Visitors By Age")
            {

                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from Visitor ORDER BY Age ASC", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }

            }



            else if (temp == "Sort Exibition By End Date")
            {
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from Exibition ORDER BY EndDate ASC", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    dataGridView1.DataSource = tb;
                    sql.Close();

                }


            }
        }
    }
}
