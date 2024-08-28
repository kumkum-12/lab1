using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q5
    {
        public static void q5()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            int[] reversedHistory = new int[searchHistory.Length];

            for (int i = 0; i < searchHistory.Length; i++)
            {
                reversedHistory[i] = searchHistory[searchHistory.Length - 1 - i];
            }

            Console.WriteLine("Reversed search history:");
            foreach (int item in reversedHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
