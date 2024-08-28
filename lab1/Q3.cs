using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q3
    {
        public static void q3()
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int maxPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > maxPrice)
                {
                    maxPrice = prices[i];
                }
            }

            Console.WriteLine("Most expensive item: " + maxPrice);
        }
    }
}
