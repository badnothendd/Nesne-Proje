using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneprojee
{
    
    class Siparis:Odeme
    {
       // ödeme burda hesaplansa yanlış mı yani mantıken yanlış sanırım nereye taşıyayım eklenen ürünün adeti var mı sizde miktarı var kg ı yani

        public DateTime SiparisTarihi { get; set; }
        public double Kg { get; set; }
        public string SiparisDurumu { get; set; }
        public double VergiTutari { get; set; }

        public void VergiHesabi()
        {
            VergiTutari = (OdemeMiktari * (0.02));
        }
        public double ToplamTutar(int miktar, string urun)
        {
            
            if (urun == "finduk")
            {
                OdemeMiktari = (miktar * 100);
               
                
            }
            else if (urun == "fistuk")
            {
                OdemeMiktari = (miktar * 200);
            }
            else //kaju
            {
                OdemeMiktari = (miktar * 300);
            }

            return OdemeMiktari;
            //labela urunu girdikten sonra kg fiyatı cıksın kullanıcının girdiği sayıyl1a çarpılsın!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!111
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            
            /*
            OdemeMiktari += finduk + VergiTutari;
            OdemeMiktari += fistuk + VergiTutari;
            OdemeMiktari += kaju + VergiTutari;
            */
        }
        public void ToplamAgirlik()
        {

        }
    }
}
