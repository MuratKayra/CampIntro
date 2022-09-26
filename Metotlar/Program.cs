namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun { Id = 2, Adi = "Armut", Aciklama = "Sulu sulu", Fiyati = 16 };

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Karpuz";
            urun3.Aciklama = "Diyarbakır karpuzu";
            urun3.Fiyati = 80;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Fiyati + " : " + urun.Aciklama);
            }
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("-------------");
            sepetManager.Ekle2("Armut", "Yeşil armut", 15, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 10);
        }
    }
}