using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q10
    {
        public static void q10()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            List<int> commonElements = new List<int>();

            foreach (int element in dataset1)
            {
                foreach (int target in dataset2)
                {
                    if (element == target && !commonElements.Contains(element))
                    {
                        commonElements.Add(element);
                    }
                }
            }

            Console.WriteLine("Common elements:");
            foreach (int element in commonElements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
