using Algorithms.Interfaces;
using System;

namespace Fibanacci
{
    public class Fibanacci : IAlgorithm
    {
        public  void Run()
        {
            int n = 100;
            long[] mem = new long[n + 1];
            Array.Fill<long>(mem, -1);

            Console.WriteLine(FibNaive(n, mem));
            Console.WriteLine(FibEffective(10));
            Console.WriteLine(FibEffective(100));
            Console.ReadKey();
        }

        // O(2^n)
        private  long FibNaive(int n, long[] mem)
        {
            if (mem[n] != -1)
                return mem[n];

            if (n <= 1)
            {
                return n;
            }

            mem[n] = FibNaive(n - 1, mem) + FibNaive(n - 2, mem);
            return mem[n];
        }

        // O(n)
        private static long FibEffective(int n)
        {
            long[] arr = new long[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
        }
    }
}
