using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini
{
    public partial class Form7 : Form
    {
        bool isgameOver;
        int time = 0, time1 = 0, time2 = 0;
        int speedUser = 10, enemySpeed1 = 12;
        int playerHeath1 = 100;
        int playerHeath2 = 100;
        int score1 = 0, score2 = 0;
        int level = 0;
        int bulletSpeed1, bulletSpeed2;
        int index1 = 0;
        Random rand = new Random();
        Move move = new Move();
        bullet Bullet = new bullet();
        public Form7()
        {
            InitializeComponent();
            restGame();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            this.Hide();
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                move.up1 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                move.down1 = true;
            }
            ////////////////////////////////////
            if (e.KeyCode == Keys.Up)
            {
                move.up2 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                move.down2 = true;
            }
            /////////////////////////////////


        }
        private void makeBullet()
        {

        }
        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                move.up1 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                move.down1 = false;
            }
            ////////////////////////////////////
            if (e.KeyCode == Keys.Up)
            {
                move.up2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                move.down2 = false;
            }
            /////////////////////////////////
            if (e.KeyCode == Keys.D && bullet.ShootBullet1 == false)
            {
                bullet.ShootBullet1 = true;
                pictureBox5.Left = pictureBox1.Top - 30;
                pictureBox5.Top = pictureBox1.Top + (pictureBox1.Width / 2);
            }
            if (e.KeyCode == Keys.Left && bullet.ShootBullet2 == false)
            {
                bullet.ShootBullet2 = true;
                pictureBox6.Left = pictureBox2.Top + 500;
                pictureBox6.Top = pictureBox2.Top + (pictureBox2.Width / 2);
            }
            /////////////////////////////////////////////////////
            /*if (e.KeyCode == Keys.D && bullet.ShootBullet1 == false)
            {
                bullet.ShootBullet1 = true;
                pictureBox5.Left = pictureBox1.Top - 30;
                pictureBox5.Top = pictureBox1.Top + (pictureBox1.Width / 2);
            }
            if (e.KeyCode == Keys.Left && bullet.ShootBullet2 == false)
            {
                bullet.ShootBullet2 = true;
                pictureBox6.Left = pictureBox2.Top + 500;
                pictureBox6.Top = pictureBox2.Top + (pictureBox2.Width / 2);
            }*/

            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                if (progressBar2.Value <= 0)
                {
                    nextLevel();
                }
                else
                {
                    score1 += 20;
                    pictureBox5.Top = 1000;
                    progressBar2.Value -= 20;
                    bullet.ShootBullet1 = false;

                }
            }
            if (pictureBox6.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (progressBar1.Value <= 0)
                {
                    nextLevel();

                }
                else
                {
                    score2 += 20;
                    pictureBox6.Top = -500;
                    progressBar1.Value -= 20;
                    bullet.ShootBullet2 = false;

                }
            }
                /////////////////////////////////////////////////////


            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void restGame()
        {
//            label1.Text += level.ToString();
            GameTimer.Start();
            enemySpeed1 = 6;
            bulletSpeed1 = 0;
            bulletSpeed2 = 0;
            bullet.ShootBullet1 = false;
            bullet.ShootBullet2 = false;

        }
        private void gameOver()
        {
            isgameOver = true;
            GameTimer.Stop();

        }
        private void removeBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        int seconds;
        private void Form7_Load(object sender, EventArgs e)
        {
            seconds = Convert.ToInt32(label7.Text);
            timer2.Start();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            timer2.Stop();
            MessageBox.Show("End Game.");
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }
    

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (move.up1 == true && pictureBox1.Top > 45)
            {
                pictureBox1.Top -= speedUser;
            }
            if (move.down1 == true && pictureBox1.Top < 289)
            {
                pictureBox1.Top += speedUser;
            }
            ///////////////////////////////////////////////////////////
            if (move.up2 == true && pictureBox2.Top > 45)
            {
                pictureBox2.Top -= speedUser;
            }
            if (move.down2 == true && pictureBox2.Top < 289)
            {
                pictureBox2.Top += speedUser;
            }
            /////////////////////////////////////////////////////////////
           
            ////////////////////////////////////////
            pictureBox5.Left += bulletSpeed1;
            if (bullet.ShootBullet1 == true)
            {
                bulletSpeed1 = 20;
                pictureBox5.Left += bulletSpeed1;
            }
            else
            {
                pictureBox5.Left = -300;
                bulletSpeed1 = 0;

            }
            ///////////////////////////////////
            if (bullet.ShootBullet2 == true)
            {
                bulletSpeed2 = 20;
                pictureBox6.Left -= bulletSpeed2;
            }
            else
            {
                pictureBox6.Left = 850;
                bulletSpeed2 = 0;

            }
            /////////////////////////////////////
            if (pictureBox5.Left > 751)
            {
                bullet.ShootBullet1 = false;
            }
            if (pictureBox6.Left < 0)
            {
                bullet.ShootBullet2 = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label7.Text = seconds++.ToString();
            label7.ForeColor = Color.Red;
            if (seconds > 120)
            {
                nextLevel();
            }
        }
        private void nextLevel()
        {
            GameTimer.Stop();
            timer2.Stop();
            MessageBox.Show("Level 2");
            Form8 f8 = new Form8();
            
            foreach (var item in Program.user)
            {
                if (label2.Text.Equals("Shooter 1: "+item._Name))
                {
                    if (item._FavC == "Red") { f8.pictureBox1.BackgroundImage = Properties.Resources.r1; }
                    else if (item._FavC == "Yellow") { f8.pictureBox1.BackgroundImage = Properties.Resources.y1; }
                    else { f8.pictureBox1.BackgroundImage = Properties.Resources.b1; };
                }
                if (label2.Text.Equals("Shooter 2: " + item._Name))
                {
                    if (item._FavC == "Red") { f8.pictureBox2.BackgroundImage = Properties.Resources.rl1; }
                    else if (item._FavC == "Yellow") { f8.pictureBox2.BackgroundImage = Properties.Resources.yl1; }
                    else { f8.pictureBox2.BackgroundImage = Properties.Resources.bl1; };
                }
            }
            this.Hide();
            f8.Show();
        }
     
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
