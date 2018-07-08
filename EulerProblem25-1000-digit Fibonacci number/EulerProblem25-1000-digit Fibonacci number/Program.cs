using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EulerProblem25_1000_digit_Fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger digitsNumber = 0;
            int i = 4;
            while (digitsNumber < 1000)
            {
                i++;
                digitsNumber = fibonacciTerm(i).ToString().Count();

            }
            Console.WriteLine(i);
        }

        public static BigInteger fibonacciTerm(int n)
        {
            int i;
            BigInteger fib2 = 1;
            BigInteger fib1 = 2;
            BigInteger fib = 0;
            for (i = 4; i <= n; i++)
            {
                fib = fib1 + fib2;
                fib2 = fib1;
                fib1 = fib;
            }
            return fib;
        }
    }
}
