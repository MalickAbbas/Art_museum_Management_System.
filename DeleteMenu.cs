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
    public partial class DeleteMenu : Form
    {
        public DeleteMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Museum mus = new Museum();
            this.Dispose();
            mus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelArt art = new DelArt();
            this.Dispose();
            art.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelExib exib = new DelExib();
            this.Dispose();
            exib.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelVis vis = new DelVis();
            this.Dispose();
            vis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delstaff staff = new Delstaff();
            this.Dispose();
            staff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DelMov mov = new DelMov();
            this.Dispose();
            mov.Show();
        }
    }
}
