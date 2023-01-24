namespace datetime_math;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now); //gunun tarihini getirir.
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddHours(4));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //datetime format
        Console.WriteLine(DateTime.Now.ToString("dd"));//24
        Console.WriteLine(DateTime.Now.ToString("ddd"));//mon
        Console.WriteLine(DateTime.Now.ToString("dddd"));//monday

        Console.WriteLine(DateTime.Now.ToString("MM"));//01
        Console.WriteLine(DateTime.Now.ToString("MMM"));//jan
        Console.WriteLine(DateTime.Now.ToString("MMMM"));//january

        Console.WriteLine(DateTime.Now.ToString("yy"));//23
        Console.WriteLine(DateTime.Now.ToString("yyyy"));//2023

        //Math Kutuphanesi
        Console.WriteLine(Math.Abs(-25));// mutlak alir (25)
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(22.3));//23
        Console.WriteLine(Math.Round(22.3));//22
        Console.WriteLine(Math.Round(22.7));//23
        Console.WriteLine(Math.Floor(22.7));//22

        Console.WriteLine(Math.Max(2,6));
        Console.WriteLine(Math.Min(2,6));

        Console.WriteLine(Math.Pow(3,4));// 3^4 sonucunu verir.
        Console.WriteLine(Math.Sqrt(9));// 9 un karekokunu alir.
        Console.WriteLine(Math.Log(9));// log9 un sonucunu verir.
        Console.WriteLine(Math.Exp(3));// e uzeri 3 sonucunu verir.
        Console.WriteLine(Math.Log10(10));// 10 sayisinin logaritma 10 tabanindaki sonucu verir.

        
    }
}