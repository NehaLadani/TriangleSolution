using System;

namespace Triangle
{
     public class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            // Node J:
            if (a + b > c && b + c > a && c + a > b == true)
            {
                // Node K:
                Console.WriteLine($"It is a Triangle");

                // Node L:
                if (a == b && b == c && c == a)
                {
                    // Node M:
                    return "It is an Equilateral Triangle";
                }
                // Node N:
                else if (a == b || b == c || a == c)
                {
                    // Node O:
                    return "It is an Isosceles Triangle";
                }
                // Node P:
                else
                {
                    return "It is a Scalene Triangle";
                } // Node Q:

            }
            // Node R:
            else
            {
                return "It is not a Triangle";
            }
        }
    }
}


    

