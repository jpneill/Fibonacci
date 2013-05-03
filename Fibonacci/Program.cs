using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Fibonacci(n);
            //sequence starts 0, 1, 1, 2, 3, 5, 8
            //n = 4 should return 3 since 0 is the 0th term in the sequence
            Console.WriteLine("{0} number in the sequence is: {1}", n, result);
        }

        static int Fibonacci(int n)
        {
            //if n is less than 0 return 0;
            if (n < 0)
                return 0;

            //if n is less than 2 and greater than 0 return n;
            if (n < 2)
                return n;

            int next = 0;

            //seeds for sequence are the first two terms
            int f0 = 0;
            int f1 = 1;

            for (int i = 2; i <= n; i++)
            {
                next = f0 + f1;
                f0 = f1;
                f1 = next;
            }

            return next;
        }
    }
}
