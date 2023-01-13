using System;

namespace methodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Basarili!");
                Console.WriteLine(outSayi);
            }
            else
                Console.WriteLine("Basarisiz!");

            Metotlar instance= new Metotlar();
            instance.Topla(4, 5, out int toplamaSonucu);
            Console.WriteLine(toplamaSonucu);
            
            //Overloadinng

            int ifade = 222;
            instance.EkranaYazdir(Convert.ToString(ifade)); 
            instance.EkranaYazdir(ifade);



        }
    }

    class Metotlar
    {
        public void Topla(int x, int y, out int toplam)
        {
            toplam = x + y;
        }
        public void EkranaYazdir(int deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger1, string deger2)
        {
            Console.WriteLine(deger1 + deger2);
        }
    }
}
