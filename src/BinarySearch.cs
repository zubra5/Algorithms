using Algorithms.Interfaces;
using System;

namespace Fibanacci
{
    public class BinarySearch : IAlgorithm
    {
        public  void Run()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine($"Key of 12: {Calculate(arr, 12, 0, arr.Length-1)}");

            Console.ReadKey();
        }

        public  int Calculate(int[] arr, int key, int low , int high )
        {
            
            if (low > high)
            {
                return -1;
            }
            int middle = low + (high - low) / 2;

            if (key < arr[middle])
            {
                high = middle - 1;
            }
            else if (key > arr[middle])
            {
                low = middle + 1;
            }
            else
            {
                return middle;
            }

            return Calculate(arr, key, low, high);
        }
    }
}
