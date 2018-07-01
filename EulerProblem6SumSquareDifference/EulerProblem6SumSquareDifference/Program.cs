using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Sum square difference
Problem 6 
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

namespace EulerProblem6SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int i;
            for(i=1;i<=100;i++)
            {
                sumOfSquares += i * i;
            }
            //Console.WriteLine(sumOfSquares);

            int squareOfSum = 0;
            int sum = 0;
            i = 0;
            for(i=1;i<=100;i++)
            {
                sum += i;
            }
            squareOfSum = sum * sum;
            int difference = squareOfSum - sumOfSquares;
            Console.WriteLine(difference);
        }
    }
}
