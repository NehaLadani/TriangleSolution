using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
     public class MainTriangle
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine($"1. Enter Triangle Dimensions ");
                    Console.WriteLine($"2. Exit");
                    int i = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        Console.WriteLine($"Enter the side1 of the triangle ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter the side2 of the triangle");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter the side3 of the triangle ");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                        break;
                    }

                    else if (i == 2)
                    {
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Dimensions entered are incorrect");
            }

        }
    }
}
        
    

