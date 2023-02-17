using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harry_Bird_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            HarryKodder f1 = new HarryKodder();
            f1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            HarryKodder f1 = new HarryKodder();
            
            f1.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            HarryKodder f1 = new HarryKodder();
        
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}
