using Algorithms.Interfaces;
using System;

namespace Fibanacci
{
    public class MinStops: IAlgorithm
    {
        public void Run()
        {

            var stations = new int[] { 0, 200, 375, 550, 750, 950 };
            var capacity = 400;
            Console.WriteLine(Calculate(stations, capacity));
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stations"></param>
        /// <param name="capacity"></param>
        /// <returns>-1 if it's impossible to get from A to B</returns>
        public static int Calculate(int[] stations, int capacity)
        {
            var result = 0;// the best
            var currentStop = 0;
            //O(n^2)
            while (currentStop < stations.Length-1)
            {
                var nextStop = currentStop;
                while (nextStop < stations.Length -1
                    && stations[nextStop+1]-stations[currentStop]<=capacity)
                {
                    nextStop++;
                }

                if (currentStop == nextStop) {
                    return -1;
                }

                if (nextStop < stations.Length - 1)
                {
                    result++;
                }

                currentStop = nextStop;
            }

            return result;
        }
    }
}
