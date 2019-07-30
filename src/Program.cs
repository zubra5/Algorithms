using Algorithms.Interfaces;
using System;

namespace Fibanacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose algorithm ");
            Console.WriteLine("1 - BinarySearch");
            Console.WriteLine("2 - Fibanacci");
            Console.WriteLine("3 - FractionalKnapsack");
            Console.WriteLine("4 - MAx number from digits ");
            Console.WriteLine("5 - Min of stations");
            var choose =  Console.ReadLine();

            IAlgorithm alg = null;
            switch (choose) {
                case "1":
                    alg = new BinarySearch();
                    break;
                case "2":
                    alg = new Fibanacci();
                    break;
                case "3":
                    alg = new FractionalKnapsack();
                    break;
                case "4":
                    alg = new GreedyAlgorithms();
                    break;
                case "5":
                    alg = new MinStops();
                    break;
                default:
                    Console.WriteLine("Wrong algorithm");
                    break;
            }     

            alg?.Run();
            Console.ReadKey();
        }
    }
}
