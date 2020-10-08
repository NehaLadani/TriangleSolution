using System;

namespace Triangle
{
    class TriangleSolver
    {
        public static void Analyze(int a, int b, int c)
        {
            if(a + b > c && b + c > a && c + a > b == true)
            {
                Console.WriteLine($"It is a Triangle");
            }
        }
    }
}
