using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum_Catalog_of_art_
{
    public partial class Museum : Form
    {
        public Museum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMenu menu = new AddMenu();
            menu.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Showmenu menu = new Showmenu();
            this.Hide();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteMenu men = new DeleteMenu();
            this.Hide();
            men.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FilterData data = new FilterData();
            this.Hide();
            data.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataSort sort = new DataSort();
            this.Hide();
            sort.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Summary summary = new Summary();
            this.Hide();
            summary.Show();
        }
    }
}
