using System;
class Program
{
    static void Main(string[] args)
    {
        string degisken = "cSharp Hoşgeldiniz", degisken2 = "Merhaba";

        //Lenght
        Console.WriteLine(degisken.Length);

        //küçük harf
        Console.WriteLine(degisken.ToLower());

        //buyuk harf
        Console.WriteLine(degisken.ToUpper());

        //Concat
        Console.WriteLine(String.Concat(degisken, " İdil!"));

        // compare, compareto

        Console.WriteLine(degisken.CompareTo(degisken2));

        Console.WriteLine(String.Compare(degisken, degisken2, true)); //true diyince büyük-küçük harf duyarsız

        //Contains

        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.Contains("cSharp"));

        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
        Console.WriteLine(degisken.StartsWith("c"));

        //index
        Console.WriteLine(degisken.IndexOf("cS"));
        Console.WriteLine(degisken.LastIndexOf("i"));

        //insert
        Console.WriteLine(degisken.Insert(0, "Ders: "));

        //padleft, padright
        Console.WriteLine(degisken.PadRight(30, '*') + degisken2); //tek tırnak olmak zorunda
        Console.WriteLine(degisken + degisken2.PadLeft(30)); //30 a tamamlayacak kadar bosluk ekler (30 tane değil)

        //remove
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(0,1));

        //replace
        Console.WriteLine(degisken.Replace(" ","*"));

        //split
        Console.WriteLine(degisken.Split(' ')[1]);

        //substring
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,4));
     }
}