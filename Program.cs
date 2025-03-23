using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TestProject1"), InternalsVisibleTo("GUI")]


namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the capacity: ");
            int cap = int.Parse(Console.ReadLine());

            BackpackProblem plecak = new BackpackProblem(n, seed);
            Console.WriteLine("\nGenerated items: ");
            Console.WriteLine(plecak);
            Console.WriteLine("\n-------------------------------------------");



            Result result = plecak.Solve(cap);
            Console.WriteLine("\nSolution:");
            Console.WriteLine(result);

        }
    }
}
