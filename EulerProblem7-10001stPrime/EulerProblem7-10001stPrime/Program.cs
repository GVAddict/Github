using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem7_10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbersList = new List<int>();
            primeNumbersList.Add(2);
            primeNumbersList.Add(3);
            int currentOrder = primeNumbersList.Count;
            bool prime = true;
            int primeTestNumber = 5;
            int i = 0;
            while (currentOrder <= 10001)
            {
                prime = true;
                for (i = 0; i < currentOrder; i++)
                {
                    if (primeTestNumber % primeNumbersList[i] == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    primeNumbersList.Add(primeTestNumber);
                    currentOrder += 1;
                }
                primeTestNumber += 1;
                i = 0;
            }
            Console.WriteLine(primeNumbersList[10001 - 1]);

        }

    }
}


