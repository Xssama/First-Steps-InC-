using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //you dont specify any type here , automatically will be specified
            var Var1 = new { Firstname = "nassim", Lastname = "Zaml", Age = 20 };
           
            Console.WriteLine("Exemple1:");
            Console.WriteLine("First Name: " + Var1.Firstname);
            Console.WriteLine("Last Name : " + Var1.Lastname);
            Console.WriteLine("Age: " + Var1.Age);
            var Var2 = new { Firstname = "Marwane", Lastname = "Rabhi", Age = 23, adresse = new { city = "Oujda", Country = "Morocco" } };
            Console.WriteLine("\n\nExemple2");
            Console.WriteLine("first Name: "+ Var2.Firstname);
            Console.WriteLine("Last Name: "+ Var2.Lastname);
            Console.WriteLine("Age: "+ Var2.Age);
            Console.WriteLine("City: "+ Var2.adresse.city);
            Console.WriteLine("Cuntry: "+ Var2.adresse.Country);
            Console.ReadKey();

        }
    }
}
