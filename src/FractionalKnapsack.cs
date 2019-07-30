using System;
using Algorithms.Interfaces;

namespace Fibanacci
{
    public class FractionalKnapsack: IAlgorithm
    {
        public  void Run()
        {
            Console.WriteLine($"Value: {Calculate()}");

            Console.ReadKey();
        }

        public  double Calculate()
        {
            var item1 = new Item(4, 20);
            var item3 = new Item(2, 14);
            var item2 = new Item(3, 18);


            var items = new[] { item1, item2, item3 };
            //O(n*log(n))
            Array.Sort(items, delegate (Item x, Item y) { return x.ValuePerWeight().CompareTo(y.ValuePerWeight()); });
            Array.Reverse(items);

            Console.WriteLine(String.Join<Item>(string.Empty, items));

            const int W = 7;

            int weightSoFar = 0;
            double valueSoFar = 0;
            int currentItem = 0;
            while (currentItem < items.Length && weightSoFar != W)
            {
                double k = 1;

                if (weightSoFar + items[currentItem].getWeight() >= W)
                {
                    k = (W - weightSoFar) / (double)items[currentItem].getWeight();
                }

                valueSoFar += k * items[currentItem].getValue();
                weightSoFar += (int)Math.Round(k * items[currentItem].getWeight());

                currentItem++;
            }

            return valueSoFar;
        }
    }

    public class Item
    {
        private int weight;
        private int value;

        public Item(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
        }

        public double ValuePerWeight()
        {
            return value / weight;
        }

        public int getWeight()
        {
            return weight;
        }

        public int getValue()
        {
            return value;
        }

        public override string ToString()
        {
            return "{w:" + weight + ",v:" + value + "}";
        }
    }
}
