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
        }
}