using System;

namespace Main
{
   internal class Program
        {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine(rnd.Next(10, 21)); // returns random integers >= 10 and < 20
            }
        }
    }
}
