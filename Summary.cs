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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        interface print
        {
            void display();
            
        }
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vp\LABS\Lab-04\Museum(Catalog of art)\Museum(Catalog of art)\Museum.mdf;Integrated Security=True";


        class Display : print
        {
            public void display()
            {
                MessageBox.Show("Completed Successfully");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Museum back = new Museum();
            this.Dispose();
            back.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.GetItemText(comboBox1.SelectedItem);
            
            label1.Text = " ";
            if(temp == "Visitors Whose Age is Greater than 20")
            {
               
                using (SqlConnection sql = new SqlConnection(connectionstring))
                {
                   
                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from Visitor where Age>20", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);
                    
                    dataGridView1.DataSource = tb;
                    sql.Close();
                    label1.Text = "The Number of Visitors Whose Age is \n greater than 20 are "+ tb.Rows.Count.ToString() + ". \n These are Following";

                }


            }

            else if(temp == "Museum Staff Whose name Starts with A")
            {

                using (SqlConnection sql = new SqlConnection(connectionstring))
                {

                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from MuseumStaff where StaffName LIKE 'A%'", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);

                    dataGridView1.DataSource = tb;
                    sql.Close();
                    label1.Text = "The Staff Whose Name starts with \n A are " + tb.Rows.Count.ToString() + ". \n These are Following";

                }

                }


            else if (temp == "Art Movement Happens Before 2023")
            {


                using (SqlConnection sql = new SqlConnection(connectionstring))
                {

                    sql.Open();
                    SqlDataAdapter db = new SqlDataAdapter("Select * from ArtMovement where Year<2023", sql);
                    DataTable tb = new DataTable();
                    db.Fill(tb);

                    dataGridView1.DataSource = tb;
                    sql.Close();
                    label1.Text = "The Art Movement That Happens Befors \n2023 are " + tb.Rows.Count.ToString() + ". \nThese are Following";


                }
                }
            }
    }
}
