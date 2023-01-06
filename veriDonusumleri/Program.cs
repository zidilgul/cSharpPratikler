using System;

namespace veriDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;

            System.Console.WriteLine("d: " + d);

            long h = d;
            System.Console.WriteLine("h: " + h);

            float i = h;
            System.Console.WriteLine("i: " + i);

            string e = "idil";
            char f = 'a';
            object g = e + f + d;

            System.Console.WriteLine("g: " + g);


            //Explicit Conversion (Açık, Bilinçli Dönüşüm. C#'ın yapamadığı bizim yaptığımız dönüşümler.)

            System.Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x; //Integer türdeki değişkeni byte türüne cast ediyorum.
            System.Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;//Integer türdeki değişkeni byte türüne cast ediyorum.
            System.Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w; //Float türü, byte türüne explicit yöntemle cast ediyorum.
            System.Console.WriteLine("v: " + v);

            // *** ToString Metodu ***
            System.Console.WriteLine("***** ToString Metodu *****");
            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            System.Console.WriteLine("zz: " + zz);

            //System.Convert
            System.Console.WriteLine("***** System.Convert sınıfı *****");

            string s1 = "33", s2 = "20";
            int sayi1, sayi2, Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            System.Console.WriteLine("Toplam: " + Toplam);

            //Parse
            System.Console.WriteLine("***** Parse *****");
            ParseMethod();

            static void ParseMethod()
            {
                string metin1 = "10";
                string metin2 = "10.25";
                int rakam1;
                double double1;

                rakam1 = Int32.Parse(metin1);
                double1 = Double.Parse(metin2);

                System.Console.WriteLine("Rakam1: " + rakam1);
                System.Console.WriteLine("Double1: " + double1);
            }
        }
    }
}