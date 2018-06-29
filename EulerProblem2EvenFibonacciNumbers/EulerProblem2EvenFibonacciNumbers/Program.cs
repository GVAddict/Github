using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem2EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Fib = 0, FibMinusTwo = 1, FibMinusOne = 2;
            int FibEvensSum = 2;
            while(Fib<=4000000)
            {
                Fib = FibMinusTwo + FibMinusOne;
                FibMinusTwo = FibMinusOne;
                FibMinusOne = Fib;
                if (Fib % 2 == 0)
                {
                    FibEvensSum += Fib;
                };
                //Console.WriteLine(FibEvensSum);
            };
            Console.WriteLine(FibEvensSum);
        }
    }
}
