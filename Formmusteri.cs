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
            //Convert.ToInt32(lblurun.Text); //? lbl derken? müşteri kısmında labela yazdırdım onunla çarpsın diye ysani
            //Convert.ToInt32(cmburunsec.SelectedItem);

            Siparis s = new Siparis();
            s.ToplamTutar(Convert.ToInt32(txtmiktar.Text), cmburunsec.SelectedItem.ToString());
            lbltutar.Text =  s.ToplamTutar(Convert.ToInt32(txtmiktar.Text), cmburunsec.SelectedItem.ToString()).ToString()+" TL";
            // şu an ürün eklemeyi burda yapıyorsun formmüsteride formyöneticide değil. burdaki fiyat hesabı sadece tamam fiyat hesabını düzeltelim demedik miha evet fiyatı yonetici girecek şimdi dimi yep o zaman ayrı bir fonksiyon yazıcaz yoneticiye
            //ürünü şu an hangi classta kaydetmek istiyorsun bilmem :ddd :D +3 pay çıkartmayı biliyorsun ama :D  ıtem sınıfında olsun ne olacak ki
            // MessageBox.Show("Toplam Tutar:" + s.ToplamTutar(Convert.ToInt32(txtmiktar.Text), cmburunsec.SelectedItem.ToString()).ToString());
            //formmüsteride ürün seçildiğinde o ürünün fiyatını txtden de çekebilirsin ya ada oluşturulan nesneyi çekebilirsin
            // bak txt de satır satır ararken iki önemli metod var biri .contains(kullaniciismi) bu o satırın parantezin içinde yazdığın yazıyı içeriyorsa girer
            //yaptırmak istediğin işlem satırına. ikincisi de .startswith(neilebaşladığınıarayacaksan) bunun yazılışı farklı olabilir ama yazmaya başlayınca çıkar
            // bu da o satır arattığın kelime ile başlıyorsa işlem parantezine girer. bu iki metodu kullanarak txtde arama yapıp bilgi çekebilirsin. 
            //sadece 1. metot yetmez mi bana eğer her ürünü ayrı ayrı satır yazdıracaksan yeter çünkü ürün isimini aratıp o satıra girip hangi kelimede fiyatı yazdırdıysan
            //çekersin direkt tamam bunu kullanırım. kurgulamada bir sıkıntı var ama onu söyleyim. yani fiyatı bu formmusteri formuna girildiğinde ve ürün seçildiğinde
            //direkt çekmen gerekiyor. hepsini girdikten sonra sipariş vere tıkladıgında cekemez miyim hepsini birden hayır çünkü sepete ürün ekledikçe o eklediği ürünün
            //fiyatını görmeyecek mi adam
            //sepete ekleyip allaha dua edip ne çıkarsa bahtımıza demesin :D +3 çıkabil ir uF:DFFffff burda bile mi :fffd tamam ben seni meşgul etmeyim yüklenin bitirin
            //uğraş çekmeye o 1. işini görür ayrı satırlarda yazdıracaksan her ürünü bakıcam deneyeyim foreach ile satır satır arama yapacaksın ReadAllLines gibi bir şeydi
            // suna baksana bi 


            //tamamdır tıkır tıkır teşekkürleer rica ederim çıkıyorum bilgisayardanhoccakal


        }

        private void cmburunsec_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*  try
              {

                  string veri = "urunler.txt";
                  StreamReader oku = new StreamReader(veri);
                  // textBox1.Text = oku.ReadLine();    tek satırlar için böyle ve burda bitiyor
                  while (!oku.EndOfStream)
                  {
                      listBox1.Items.Add(oku.ReadLine());
                      //cmburunsec.Items.Add(oku.ReadLine());
                  }
                  oku.Close();
              }
              catch (Exception)
              {

                  throw;
              } */

            
            // geçmiş olsun harikaaaa teşekkür :D rica ederim kaçtım ben bırakmayın 3 kişi asılın biter bak paylaşım yapın herkes bir noktaya uğraşsın 10 puan 10 puandır tek pc den çalışmak gerekiyor hepsi baglantılı old için
            // diğerleri çalışacak mı eğer aynı koda yazabilirseniz? evet ben yazınca bakıyorlar birlikte yapmaya calışıyoruz tamam dur
            // o yükleme bitince bir link verecek sana site. o linki whatsapptan arkadaşlarına at. ordan indirsinler rarın içinden masaüstüne alsınlar. sonra .sln uzantılı olana basıp projeyi açabilirler
            // dikkat edilmesi gereken şey onlar farklı yere uğraşırken aynı değişken isimlerini kullanın hepiniz yoksa hata alırsınız. aynı proje dosyasının kopyasının üstünde değişiklik
            // yaptığınız için başkasının yaptığı değişikliği direkt kopyala yapıştırla alabilirsin bu bilgisayara. kopyala yapıştırla alınca butonlar çalışmaz sadece onu da şöyle çözüyorsun
            // kod doğru görünür ama butona tıkladığında işlem yapmaz. kendi bilgisayarında o butonun üstüne çift tıklıyorsun yukardaki butona tıklayınca ne kod okunacaksa bu tarafa yapıştırıyorsun
            // diğerini siliyorsun. böyle sorunsuz hale gelir. ok? tamamdır yuklenince bakıca mtesekkurler .çook. rica ederim kolay gelsin salmayın biter hadi kolay gele sana da. çıktım bilgisayardan



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
