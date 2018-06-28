using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToAngle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input hour [0-11]: ");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Input minute [0-59]: ");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Angle is {0:0.00} degrees", TimeToAngle(hour, minute));
            Console.ReadKey();


        }

        public static float TimeToAngle(int hour, int minute)
        {
            int minutes = hour * 60 + minute;
            float angle = minutes / (float)2;
            if (angle < 180)
            { return angle; }
            else if (angle == 180)
            { return 180; }
            else
            { return 360 - angle; }
        }
    }
}
