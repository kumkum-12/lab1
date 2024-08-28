using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q4
    {
        public static void q4()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int maleCount = 0;
            int femaleCount = 0;

            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }

            Console.WriteLine("Male participants: " + maleCount);
            Console.WriteLine("Female participants: " + femaleCount);
        }
    }
}
