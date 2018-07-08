using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EulerProblem16_PowerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
        
                BigInteger number = (BigInteger)Math.Pow(2, 1000);
            Console.WriteLine(digitSum(number));
        }

        public static int digitSum(BigInteger number)
        {
            int sum=0;
            while(number>0)
            {
                sum += (int)(number % 10);
                number = number / 10;
            }
            return sum;
        }
    }
}

