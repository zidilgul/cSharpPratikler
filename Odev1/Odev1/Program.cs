using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodluyoruz_.NET_odev1
{

    public class Program
    {
        static void Main(string[] args)
        {

           // soru1();
           // soru2();
           // soru3();
            soru4();

        }

        public static void soru1() {

            Console.WriteLine("Pozitif Bir Sayı Giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " Adet Daha Pozitif Sayı Giriniz");
            int[] sayilar = new int[n];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Sayi: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Sayılar İçinde Çift Olanlar");
            foreach (int i in sayilar)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadLine();

        }
        public static void soru2() {

            Console.WriteLine("Birinci Sayıyı Giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz");
            int m = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Sayı :");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Sayılardan İkinci Sayıya Eşit Olan veya Tam Bölünebilenler ---- " + "İkinci Sayı: " + m);
            foreach (int sayi in sayilar)
            {
                if (sayi % m == 0 || sayi == m)
                {
                    Console.WriteLine(sayi);
                }
            }
            Console.ReadLine();

        }
        public static void soru3() {

            Console.WriteLine("Pozitif Bir Sayı Giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " Adet Kelime Giriniz ");
            string[] kelimeler = new string[n];

            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Kelime");
                kelimeler[i] = Console.ReadLine();

            }
            Console.WriteLine("---------");
            foreach (string kelime in kelimeler.Reverse())
            {
                Console.WriteLine(kelime);

            }

            Console.ReadLine();


        }
        public static void soru4() {

            Console.WriteLine("Bir Cümle Yazınız...");
            string cumle = Console.ReadLine();
            cumle = cumle.ToLower();

            int kelime_sayisi = cumle.Count();
            string harfler = "abcçdefgğhıijklmnoöprsştuüvyzxwq";
            int harf_sayisi = 0;
            for (int i = 0; i < kelime_sayisi; i++)
            {
                if (harfler.Contains(cumle[i]))
                {
                    harf_sayisi++;
                }
            }

            Console.WriteLine("Harf Sayısı: " + harf_sayisi);

            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayisi: " + kelimeler.Length);

            Console.ReadLine();
        }

    }
}