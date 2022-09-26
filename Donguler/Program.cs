namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici";
            string kurs2 = "Programlamaya giriş";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirici", "Programlamaya giriş", "Java", "Python" };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
        }
    }
}