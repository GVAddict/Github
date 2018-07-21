using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Smallest multiple
Problem 5 
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20? 
 */
namespace ProjectEulerProblem5_SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(smallestMultiple());
        }

        public static long smallestMultiple()
        {
            int i = 0; //divisor
            long j = 21; //number to test for smallest multiple
            int numberOfDivisors = 0;
            bool found = false;
            while (found == false)
            {
                for (i = 1; i <= 20; i++)
                {
                    if (j % i == 0)
                    {
                        numberOfDivisors += 1;
                    }
                    else
                    { break; }
                }
                if (numberOfDivisors == 20)
                    found = true;
                else
                    j++;
                numberOfDivisors = 0;
            }
            return j;
        }
    }
}
