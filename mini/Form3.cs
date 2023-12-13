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
    
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
       
    }
       
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg(*.jpg)|*.jpg|png(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           pictureBox1.BackgroundImage = Properties.Resources.b1 ;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.r1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.y1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.profile++;
            User obj = new User();
            obj._Name = textBox2.Text;
            if (comboBox1.Text == "")
            { obj._Age = int.Parse(comboBox1.SelectedItem.ToString()); }
            else { obj._Age = int.Parse(comboBox1.Text.ToString()); }
            if (radioButton1.Checked) obj._Gender = radioButton1.Text;
            if (radioButton2.Checked) obj._Gender = radioButton2.Text;
            if (radioButton3.Checked) obj._FavC = radioButton3.Text;
            if (radioButton4.Checked) obj._FavC = radioButton4.Text;
            if (radioButton5.Checked) obj._FavC = radioButton5.Text;
            Program.user.Add(obj);
            this.Hide();
             Form5 form5 = new Form5();
             form5.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
