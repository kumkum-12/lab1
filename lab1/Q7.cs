using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q7
    {
        public static void q7()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int index = -1; 

            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    index = i; 
                    break; 
                }
            }

            if (index != -1)
            {
                Console.WriteLine("Book found at index: " + index);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}
