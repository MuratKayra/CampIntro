using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " ürünü sepete eklendi!");
        }

        public void Ekle2(string urunAdi, string aciklama, int fiyati, int stokAdedi)
        {
            Console.WriteLine(urunAdi + " ürünü sepete eklendi!");
        }
    }
}
