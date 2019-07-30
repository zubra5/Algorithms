using Algorithms.Interfaces;
using System;

namespace Fibanacci
{
    public class GreedyAlgorithms: IAlgorithm
    {
        public  void Run()
        {
            int[] digits = { 3, 1, 7, 9, 9, 5 };
            Console.WriteLine(MaxNumberFromDigits2(digits));
            Console.ReadKey();
        }

        public static string MaxNumberFromDigits(int[] digits)
        {
            //O(n*long(n))
            //O(n)
            //O(n*long(n))
            Array.Sort(digits);

            string result = string.Empty;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                result += digits[i];
            }

            return result;
        }

        public static string MaxNumberFromDigits2(int[] digits)
        {
            //O(n*long(n))
            //O(n)
            //O(n*long(n))
            Array.Sort(digits);
            Array.Reverse(digits);
            return String.Join(string.Empty, digits);
        }
    }
}
