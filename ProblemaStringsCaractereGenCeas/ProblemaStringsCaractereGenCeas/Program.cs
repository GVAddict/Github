using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problema strings facultativa
Sa se scrie o metoda care sa primeasca ca parametrii un array de strings (Row) si un int. Metoda sa
afiseze valoarea int-ului cu caractere "gen ceas"
exemplu pentru int-ul 123 sa se afiseze
__#_###_###
__#___#___#
__#_###_###
__#_#_____#
__#_###_###
in acel array de rows trimis ca parametru se vor afla 5 stringuri care afisate cu Console.WriteLine in
ordinea Row[0], Row[1], Row[2], Row[3], Row[4] sa afiseze 1234567890
string[] Row = new string[5];
Row[0]="__#_###_###_#_#_###_###_###_###_###_###_"
Row[1]="__#___#___#_#_#_#___#_____#_#_#_#_#_#_#_"
Row[2]="__#_###_###_###_###_###___#_###_###_#_#_"
Row[3]="__#_#_____#___#___#_#_#___#_#_#___#_#_#_"
Row[4]="__#_###_###___#_###_###___#_###___#_###_"
int n=123;
Afisare(Row, n);
public static void Afisare(string[] Row, int n);
daca sunt necesare detalii va rog sa ma contactati la andrei.patrascu@yahoo.com
*/

namespace ProblemaStringsCaractereGenCeas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Row = new string[5];//de pus 0 (zero) pe prima pozitie si refacut program
            Row[0] = "###___#_###_###_#_#_###_###_###_###_###_";
            Row[1] = "#_#___#___#___#_#_#_#___#_____#_#_#_#_#_";
            Row[2] = "#_#___#_###_###_###_###_###___#_###_###_";
            Row[3] = "#_#___#_#_____#___#___#_#_#___#_#_#___#_";
            Row[4] = "###___#_###_###___#_###_###___#_###___#_";

            Afisare(Row, 420);
        }

        public static void Afisare(string[] Row, int n) //int does not allow for leading zeros as input
        {
            int digitNumber = n.ToString().Count(); //counts number of digits
            int[] digit = new int[digitNumber]; //creates array of size number of digits
            int i = 0;
            for (i = 0; i < digitNumber; i++) //creates array with digits from input number n as elements
            { digit[i] = n % 10; n /= 10; }
            //Console.WriteLine(Row[0].Substring(0, 4));
            for (int j = 0; j < 5; j++) //row iterator & display
            {
                for (i = digitNumber-1; i >= 0; i--) //digit iterator & display
                {
                    int pos = (digit[i]) * 4;
                    Console.Write(Row[j].Substring(pos, 4));
                }
                Console.WriteLine("\n");
            }

        }

    }



}


