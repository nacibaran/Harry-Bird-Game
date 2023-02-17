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
    public partial class HarryKodder : Form
    {
        int boruHızı = 7;
        int gravity = 10;
        int score = 0;
        
         public HarryKodder()
        {
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            pctrHarry.Top += gravity;
            pctrColonAlt.Left -= boruHızı;
            pctrColonUst.Left -= boruHızı;
            lblScore.Text = "Score : " + score;
            Random random = new Random();

            pictureBox1.Top = pctrHarry.Top+(random.Next(-20,20 ));

            if(pctrColonAlt.Left<=-10)
            {
                pctrColonAlt.Left = random.Next(700,790);
                score++;
            }
            if ( pctrColonUst.Left<=-10)
            {
                pctrColonUst.Left = random.Next(810,950);
                score++;
            }
            if(pctrHarry.Bounds.IntersectsWith(pctrColonAlt.Bounds)||pctrHarry.Bounds.IntersectsWith(pctrup.Bounds) || pctrHarry.Bounds.IntersectsWith(pctrColonUst.Bounds)|| pctrHarry.Bounds.IntersectsWith(pctrZemin.Bounds))
          {
                endGame();
            }
        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space )
            {
                gravity = -10;
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void pctrColonUst_Click(object sender, EventArgs e)
        {
        }
        private void endGame()
        {
            gameTimer.Stop();
            MessageBox.Show("GameOver");
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void pctrColonAlt_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
