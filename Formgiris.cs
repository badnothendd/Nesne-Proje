using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesneprojee
{
    public partial class Formgiris : Form
    {
        public Formgiris()
        {
            InitializeComponent();
        
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "y" && textBox2.Text == "1")
            {
                Formyonetici seyahat = new Formyonetici();
                seyahat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("doğru girsene kardeşim");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "tuğba" && textBox3.Text == "123" || textBox4.Text == "derya" && textBox3.Text == "123" || textBox4.Text == "zehra" && textBox3.Text == "123")
            {
               
                Formmusteri kullanici = new Formmusteri();
                kullanici.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("doğru girsene kardeşim");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
