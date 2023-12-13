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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            
            InitializeComponent();
            
            foreach (var item in Program.user)
            {
                LB1.Items.Add(item._Name);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Program.user)
            {
                if(item._Name.Equals(Program.user[LB1.SelectedIndex]._Name))
                {
                    L7.Text = item._Name;
                    label8.Text = item._Age.ToString();
                    label10.Text = item._Gender;
                    label9.Text = item._FavC;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.profile >= 2)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must add other profile");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
