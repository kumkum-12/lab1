using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Q9
    {
        public static void q9()
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            List<int> uniqueIds = new List<int>();

            foreach (int id in ids)
            {
                if (!uniqueIds.Contains(id))
                {
                    uniqueIds.Add(id);
                }
            }

            Console.WriteLine("Unique IDs:");
            foreach (int id in uniqueIds)
            {
                Console.WriteLine(id);
            }
        }
    }
}
