using System;
class Program
{
        private static void Main(string[] args)
        {

                try{  
                        Console.WriteLine("Bir sayı giriniz: ");
                        int sayi = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Sayınız = " + sayi);
                }
                catch(Exception exc){
                        Console.WriteLine(exc.Message);  

                }
                finally{
                        System.Console.WriteLine("program sonlandı");

                }
              }
}