using System;

namespace Main
{
   internal class Program
        {
        static void Tabs(int a)
        {
            if (a <= 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Tabs(10-i);
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
