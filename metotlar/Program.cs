using System;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // erişim_belirteci geri_dönüştipi metot_adı(parametreListesi/argüman) ==> şablon
            // {
            // komutlar 
            // return
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

        }

        static int Topla(int değer1, int değer2) // static classlara static metotlar erişebilir
        {
            return (değer1 + değer2);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri) /// erişilebilir olması için public olmalı
        {
            Console.WriteLine(veri);
        }
    }
}
