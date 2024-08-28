using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q6
    {
        public static void q6()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            int[] adjustedMeasurements = new int[measurements.Length];

            for (int i = 0; i < measurements.Length; i++)
            {
                adjustedMeasurements[i] = measurements[i] * factor;
            }

            Console.WriteLine("Adjusted measurements:");
            foreach (int item in adjustedMeasurements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
