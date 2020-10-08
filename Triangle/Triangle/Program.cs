using System;

namespace Triangle
{
     public class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            if (a + b > c && b + c > a && c + a > b == true)
            {
                Console.WriteLine($"It is a Triangle");

                if (a == b && b == c && c == a)
                {
                    return "It is an Equilateral Triangle";
                }
                else if (a == b || b == c || a == c)
                {
                    return "It is an Isosceles Triangle";
                }
                else
                {
                    return "It is a Scalene Triangle";
                }
            }
            else
            {
                return "It is not a Triangle";
            }
        }
    }
}


    

