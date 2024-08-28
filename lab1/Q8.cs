using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q8
    {
        public static void q8()
        {
            int[] grades = { 56, 78, 89, 45, 67 };
            Array.Sort(grades);
            if (grades.Length < 2)
            {
                Console.WriteLine("Not enough grades to find the second smallest.");
            }
            else
            {
                Console.WriteLine("Second smallest grade: " + grades[1]);
            }
        }
    }
}
