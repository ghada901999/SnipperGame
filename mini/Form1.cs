using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace mini
{
    public partial class Form1 : Form
    {
        public static int count = 0;

       
        WindowsMediaPlayer player = new WindowsMediaPlayer(); 
        public Form1()
        {
            InitializeComponent();
            count++;
            if (count == 1)

            {

                //player.URL = "sounGame.mp3";

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4=new Form4();
            f4.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Program.profile>0)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("You Must Insert player!!");
            }
          
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.profile == 0)
            {
                MessageBox.Show(" Invalied ");
            }

            else
            {
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
