using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Number spiral diagonals
Problem 28 
Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

21 22 23 24 25
20  7  8  9 10
19  6  1  2 11
18  5  4  3 12
17 16 15 14 13

It can be verified that the sum of the numbers on the diagonals is 101.

What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way? 
 */

namespace EulerProjectProblem28_NumberSpiralDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrix_size = 1001;
            int[,] matrix = new int[matrix_size, matrix_size];
            int i = 0;//matrix middle row
            int j = 0;//matrix middle column
            int number = 1;
            int cs = (matrix_size - 1) / 2 - 1;
            int ce = (matrix_size - 1) / 2 + 1;
            int rs = (matrix_size - 1) / 2 - 1;
            int re = (matrix_size - 1) / 2 + 1; ;
            matrix[matrix_size / 2, matrix_size / 2] = number; // //middle of matrix is 1
            while (re < matrix_size || ce < matrix_size) //matrix creator
            {
                number++;
                matrix[rs + 1, ce] = number;//right next to matrix middle is 2

                for (i = rs + 2; i < re; i++) //looping right side of matrix exluding last position
                {
                    number++;
                    matrix[i, ce] = number;
                }

                for (j = ce; j > cs; j--) //looping bottom of matrix expluding last position
                {
                    number++;
                    matrix[re, j] = number;
                }

                for (i = re; i > rs; i--) //looping left of matrix excluding last position
                {

                    number++;
                    matrix[i, cs] = number;
                }

                for (j = cs; j <= ce; j++) //looping top of matrix excluding last position
                {
                    number++;
                    matrix[rs, j] = number;
                }
                rs--; re++; cs--; ce++;
            }
            int sum = 0;
            for (i = 0; i < matrix_size; i++) //The row-column condition is row=column
                for (j = 0; j < matrix_size; j++) //sums number on main diagonal
                {
                    if (i == j)
                        sum += matrix[i, j];
                }
            for (i=0;i<matrix_size;i++) //The row-column condition is row=numberOfRows - column -1
                for (j=0;j<matrix_size;j++)
                {
                    if (i==(matrix_size-j-1) && j==(matrix_size-i-1))
                        sum += matrix[i, j];
                }
            sum -= 1; //substracts middle number because is added twice
            Console.WriteLine(sum);
        }
    }
}
