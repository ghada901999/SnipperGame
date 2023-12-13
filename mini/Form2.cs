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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            foreach (var item1 in Program.user)
            {
                LB1.Items.Add(item1._Name);
                LB2.Items.Add(item1._Name);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.Game++;
            if (LB1.SelectedItem==(LB2.SelectedItem))
            {
                MessageBox.Show("Please select different Player");
            }
            else
            {
                Form7 f7 = new Form7();
                User u1 = new User();
                foreach (var item in Program.user)
                {
                    if(LB1.SelectedItem.Equals(item._Name))
                    {
                        if(item._FavC=="Red") { f7.pictureBox1.BackgroundImage = Properties.Resources.r1; }
                        else if (item._FavC == "Yellow") { f7.pictureBox1.BackgroundImage = Properties.Resources.y1; }
                        else { f7.pictureBox1.BackgroundImage = Properties.Resources.b1; };
                    }
                    if (LB2.SelectedItem.Equals(item._Name))
                    {
                        if (item._FavC == "Red") { f7.pictureBox2.BackgroundImage = Properties.Resources.rl1; }
                        else if (item._FavC == "Yellow") { f7.pictureBox2.BackgroundImage = Properties.Resources.yl1; }
                        else { f7.pictureBox2.BackgroundImage = Properties.Resources.bl1; };
                    }
                }
                f7.Show();
                this.Hide();
                f7.label2.Text += LB1.SelectedItem;
                f7.label5.Text += LB2.SelectedItem;

                //string name = LB1.SelectedItem.ToString();
            }
        }
        
        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
