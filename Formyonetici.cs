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
    public partial class Formyonetici : Form
    {
        Formmusteri musteri = new Formmusteri();
      



        public Formyonetici()
        {
            InitializeComponent();
            btnurunekle.Hide();
            btnuruncıkar.Hide();
            txtfiyat.Hide();
            btnfiyat.Hide();

        }
        public static string SilinecekUrun;

        private void btnurunekle_Click(object sender, EventArgs e)
        {
          try
            {
                FileStream fs = new FileStream("urunler.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(txturunekle.Text + "\n");             
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen önce doldurunuz");
            }
             cmburuncikar.Items.Add(txturunekle.Text); 
           
           
          /*  Item i = new Item();
             i.MiktarUcret(Convert.ToInt32(txtfiyat));  
             i.Ismi = txturunekle.Text; */
           
           // Formmusteri musteri = new Formmusteri();
             musteri.cmburunsec.Items.Add(txturunekle.Text);
             
           // musteri.Show();
           // musteri.Hide();
           txturunekle.Clear();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmburuncikar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnuruncıkar_Click(object sender, EventArgs e)
        {
            
              TextReader tReader = new StreamReader("u.txt");
              string okunan = tReader.ReadToEnd();
              tReader.Close();
              okunan = okunan.Replace(cmburuncikar.Text, "");
              TextWriter tWriter = new StreamWriter("u.txt");
              tWriter.Write(okunan);
              tWriter.Flush();
              tWriter.Close();
             
              cmburuncikar.Items.Add(txturunekle.Text);
              SilinecekUrun = cmburuncikar.SelectedItem.ToString();
              cmburuncikar.Items.Remove(cmburuncikar.SelectedItem);
              musteri.cmburunsec.Items.Remove(cmburuncikar.SelectedItem);
          

        }

        private void btnurunguncelle_Click(object sender, EventArgs e)
        {
            btnurunekle.Show();
            btnuruncıkar.Show();
        }

        private void Formyonetici_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnmusteritkp_Click(object sender, EventArgs e)
        {
             string[] lines = File.ReadAllLines("musteriler.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(' ');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnfiyat_Click(object sender, EventArgs e)
        {
            Formmusteri b = new Formmusteri();
            


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           musteri.Show();
       
            
        }
    }
}
