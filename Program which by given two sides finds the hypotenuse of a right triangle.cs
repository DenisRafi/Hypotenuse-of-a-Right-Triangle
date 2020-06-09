using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "By Denis Rafi";
            Console.Write("First side: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Second side: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Hypotenuse is: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));           
            Console.ReadKey();           
        }
    }
}
    