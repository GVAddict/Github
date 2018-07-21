using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*
 Summation of primes
Problem 10 
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million. 
 */
namespace ProjectEulerProblem10_SummationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeList = new List<int>();
            int j = 2;
            for (j = 2; j <= 2000000; j++)
            {
                if (isPrime(j) == true)
                    primeList.Add(j);
            }
            BigInteger sum = 0;
            foreach(BigInteger l in primeList)
            { sum += l; }
            Console.WriteLine(sum);
        }
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
    }
}
