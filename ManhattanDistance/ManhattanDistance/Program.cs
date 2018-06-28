using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Manhattan Distance
Sa se creeze 2 clase :point si geometry
Sa se creeze o metoda MD (manhattan distance) care sa accepte param point si sa calculeze manhattan distance intre cele 2 puncte
+MD(int point P1, int point p2) 
*/

namespace ManhattanDistance
{
    class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Points();
            int[] p1 = c1.Point(0, 0);
            var c2 = new Points();
            int[] p2 = c2.Point(4, 4);
            var MDist = new Geometry();
            int MD = MDist.ManhattanDistance(p1, p2);
            Console.WriteLine("Manhattan distance between p1({0},{1}) and p2({2},{3}) is: {4}", p1[0], p1[1], p2[0], p2[1], MD);

        }
    }

    public class Points
    {
        public int[] Point(int x, int y)
        {
            int[] arr = { x, y };
            return arr;

        }
    }

    public class Geometry
    {
        public int ManhattanDistance(int[] p1, int[] p2)
        {
            int ManhattanDistance = Math.Abs(p1[0] - p2[0]) + Math.Abs(p1[1] - p2[1]);
            return ManhattanDistance;
        }
    }
}
