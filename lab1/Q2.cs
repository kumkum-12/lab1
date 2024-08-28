using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q2
    {
        public static void q2()
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            float average = sum / scores.Length;

            Console.WriteLine("Average score: " + average);
        }
    }
}
