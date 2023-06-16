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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Museum set = new Museum();
            this.Dispose();
            set.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exhibition set = new Exhibition();
            this.Dispose();
            set.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visitor visit = new visitor();
            this.Dispose();
            visit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Artmovement art = new Artmovement();
            this.Dispose();
            art.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            staff staf = new staff();
            this.Dispose();
            staf.Show();
        }
    }
}
