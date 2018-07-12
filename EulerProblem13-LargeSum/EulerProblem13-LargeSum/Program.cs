using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EulerProblem13_LargeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = System.IO.File.ReadAllLines(@"D:\02. Programming\Github\EulerProblem13-LargeSum\EulerProblem13-LargeSum\EP13.txt");
            BigInteger sum = 0;
            foreach (string ln in line)
            {
                //Console.WriteLine(ln);
                BigInteger number = BigInteger.Parse(ln);
                sum += number;
            }
            Console.WriteLine(sum);
            string firstTenDigitsOfSum = sum.ToString().Substring(0, 10);
            Console.WriteLine("First ten digits of large sum: " + firstTenDigitsOfSum);
        }
    }
}
