using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nesneprojee
{
    public partial class Formmusteri : Form 
    {
      


        public Formmusteri()
        {
            InitializeComponent();
            
        }
        public string SilinmesiIstenenUrun;

        private void Formmusteri_Load(object sender, EventArgs e)
        {

            //   cmburunsec.Items.Add(urunekleme);
            //textBox1.Text = sifre; 
            SilinmesiIstenenUrun = Formyonetici.SilinecekUrun;
            cmburunsec.Items.Remove(SilinmesiIstenenUrun);
            button1.Hide();
            
        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btntutarhesap_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(txtmiktar.Text);
            //Convert.ToInt32(lblurun.Text); 
            //Convert.ToInt32(cmburunsec.SelectedItem);

            Siparis s = new Siparis();
            s.ToplamTutar(Convert.ToInt32(txtmiktar.Text), cmburunsec.SelectedItem.ToString());
            lbltutar.Text =  s.ToplamTutar(Convert.ToInt32(txtmiktar.Text), cmburunsec.SelectedItem.ToString()).ToString()+" TL";
        

        }

        private void cmburunsec_SelectedIndexChanged(object sender, EventArgs e)
        {

         




              if (cmburunsec.Text == "finduk")
            {
                lblurunkgfiyati.Text = "100TL";
            }
              else if (cmburunsec.Text == "fistuk")
            {
                lblurunkgfiyati.Text = "200TL";
            }
            else
            {
                lblurunkgfiyati.Text = "300TL";
            }

            //lblurun.Text = cmburunsec.SelectedItem.ToString();
            // Item a = new Item();

            // lbltutar.Text = s.ToplamTutar(Convert.ToInt32(txtmiktar.Text), cmburunsec.SelectedItem.ToString()).ToString() + " TL";
            //  a.MiktarUcret(Convert.ToInt32(tx));


        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("musteriler.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(txtadsoyad.Text + " ");
                sw.Write(txtadres.Text + " ");
                sw.Write(cmburunsec.Text + " ");
                sw.Write(txtmiktar.Text + " ");
                sw.Write(cmbodemeturu.Text + " ");
                sw.Write(lbltutar.Text + "\n");
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Siparişiniz Alınmıştır");
        }

        private void lblurunkgfiyati_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        /*    Formyonetici u = new Formyonetici();
            u.Show();
            this.Hide(); */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
