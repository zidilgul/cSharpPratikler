using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımlama 
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kurt" };

            int[] dizi;
            dizi = new int[5];

            // Dizilere erişim 
            renkler[0] = "Kırmızı";

            Console.WriteLine(hayvanlar[2]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngülerle dizi kullanımı 
            Console.Write("Dizinin eleman sayısı: ");
            int DiziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[DiziUzunlugu];

            for (int i = 0; i < DiziUzunlugu; i++)
            {
                Console.Write("{0}. elemanı girin: ", i + 1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
                toplam += sayi;

            double ort = (double)toplam / sayıDizisi.Length;

            Console.WriteLine("Ortalama: " + ort);


            }
    }
}
