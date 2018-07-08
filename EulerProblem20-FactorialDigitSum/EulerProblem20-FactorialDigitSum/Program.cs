using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EulerProblem20_FactorialDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(factorial(100));
            BigInteger f = factorial(100);
            BigInteger sum = 0;
            while (f > 0)
            {
                sum += (BigInteger)f % 10;
                f = f / 10;
            }
            Console.WriteLine(sum);
        }

        public static BigInteger factorial(int n) //return n! factorial of input number
        {
            BigInteger fact = n;
            int i = 0;
            for (i = 1; i < n; i++)
            {
                fact = fact * (n - i);
            }
            return fact;
        }

    }
}
