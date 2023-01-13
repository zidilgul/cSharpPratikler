using System;

namespace recursiveAndExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive Methods
            Islemler a= new Islemler();
            int result = a.Expo(3, 3);
            Console.WriteLine(result);

            //Extension Methods
            string ifade = "Zeynep İdil Gül";
            Console.WriteLine(ifade.CheckSpaces());

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs == 1)
                return sayi;
            else if (üs == 0)
                return 1;

            else
            {
                return (Expo(sayi, üs - 1) * sayi);

            }
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string s) //this ekleyince extension method olur
        {
            return s.Contains(" ");
        }
    }
}
