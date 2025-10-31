using System;

namespace Main
{
   internal class Program
        {

        static void Main(string[] args)
        {

            DateTime dt1 = new DateTime(2025, 10, 31);
            DateTime dt2 = new DateTime(2024, 10, 31);
            // Hours, Minutes, Seconds
            TimeSpan ts = dt1.Subtract(dt2);

            Console.WriteLine(ts.TotalDays);
            Console.ReadKey();

        }
    }
}
