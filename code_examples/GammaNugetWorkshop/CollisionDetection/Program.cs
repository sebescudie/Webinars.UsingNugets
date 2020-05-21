using System;
using GeometryTools;
using System.Numerics;

namespace CollisionDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            // linePointA and linePointB simply represent a diagonal line that crosses the middle of the screen
            Vector2 linePointA = new Vector2(-1, 1);
            Vector2 linePointB = new Vector2(1, -1);

            // pointToCheck sits right in the middle of the screen
            Vector2 pointToCheck = new Vector2(0, 0);

            Console.WriteLine("Is pointToCheck intersecting the line going from linePointA to linePointB?");
            Console.WriteLine(LineIntersection.IsPointOnLineSegment(pointToCheck, linePointA, linePointB));

            Console.ReadKey();
        }
    }
}
