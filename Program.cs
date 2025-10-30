using System;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args) 
            {
            string MyName = "Oussama Hsaini";
            string language = "C#";
               Console.WriteLine("My name is {0}!", MyName);
               Console.WriteLine("I'm learning {0}", language);
            int X = 10, Y = 20;
               Console.Write("The sum of {0} + {1} is: {2}", X, Y, (X+Y));
               
               Console.ReadKey();
            }
    }
}
