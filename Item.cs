using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneprojee
{
    class Item
    {
        public string Ismi { get; set; } 
        public decimal KargoAgirlik { get; set; }
        public string Aciklama { get; set; }
        public int Fiyat { get; set; }

        public int MiktarUcret(int ürününfiyatı)
        {
            Fiyat = ürününfiyatı;
            return Fiyat;
        }
        public void Agirlikal()
        {
        }
    }
}
