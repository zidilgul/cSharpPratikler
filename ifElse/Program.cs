internal class Program
{
        private static void Main(string[] args)
        {
                int time = DateTime.Now.Hour;

                if(time > 18)
                System.Console.WriteLine("İyi akşamlar");
                else if(time > 12)
                System.Console.WriteLine("İyi günler");
                else
                {
                        System.Console.WriteLine("İyi sabahlar");
                }

                //ternary if
                string mesaj = time > 18 ? "iyi geceler" : "iyi günler";
                System.Console.WriteLine(mesaj);
        }
}