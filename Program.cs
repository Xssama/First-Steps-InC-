using System;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args) 
            {
            var MyName = "Oussama Hsaini";
            var language = "C#";
               Console.WriteLine("My name is {0}!", MyName);
               Console.WriteLine("I'm learning {0}", language);
            var X = 10;
            var Y = 20;
               Console.Write("The sum of {0} + {1} is: {2}", X, Y, (X+Y));
               
               Console.ReadKey();
            }
    }
}
