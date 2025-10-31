using System;

namespace Main
{
   internal class Program
        {

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            Console.WriteLine(WeekDays.Friday);

            int wd = (int)WeekDays.Friday;
            Console.WriteLine(wd);

            var week_day = (WeekDays) 4;
            Console.WriteLine(week_day);
            Console.ReadKey();

        }
    }
}
