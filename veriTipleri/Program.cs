using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {


            int sayi1 = 7;
            long sayi2 = 930219213123029;
            short sayi3 = 32767;
            byte sayi4 = 255;
            double sayi5 = 3.7;
            float sayi0 = 5.8f;
            decimal sayi6 = 20.25235235M;
            var sayi7 = 5;
            sayi7 = 'A';
            int sayi8 = 'B';

            char letter1 = 'D';
            bool karar1 = false;
            int deneme1 = 69;
            var a = 653;
            a = 'C';

            DateTime dateTime = DateTime.Now;
            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            string saat = DateTime.Now.ToString("HH:mm");

            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();

            int int21 = int20 + Convert.ToInt32(str20);

            int int22 = int20 + int.Parse(str20);

            Console.WriteLine("Sayı 1 is {0}", sayi1);
            Console.WriteLine("Sayı 2 is {0}", sayi2);
            Console.WriteLine("Sayı 3 is " + sayi3);
            Console.WriteLine("{0} karakterinin sayı değeri = {1}", letter1, (int)letter1);
            Console.WriteLine((int)days.Saturday);
            Console.WriteLine("{0} günü haftanın {1}. günüdür", days.Wednesday, (int)days.Wednesday);
            Console.WriteLine(sayi8);
            Console.WriteLine((char)deneme1);
            Console.WriteLine(a);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime2);
            Console.WriteLine(saat);
            Console.ReadLine();
        }


    }
    enum days
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
