using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int sum = 0;

            for (int i = 0; i < transactions.Length; i++)
            {
                sum += transactions[i];
            }

            //Console.WriteLine("Total sum of transactions: " + sum);
            //Q2.q2();
            //Q3.q3();
            //Q4.q4();
            //Q5.q5();
            //Q6.q6();
            //Q7.q7();
            //Q8.q8();
            //Q9.q9();
            Q10.q10();
            Console.ReadKey();
        }
    }
}
