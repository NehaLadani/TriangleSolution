using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

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
                    // Node A:
                    int i = int.Parse(Console.ReadLine());
                    // Node B:
                    if (i == 1)
                    {
                        // Node C;
                        Console.WriteLine($"Enter the side1 of the triangle ");
                        // Node D:
                        int a = int.Parse(Console.ReadLine());
                        // Node E:
                        Console.WriteLine($"Enter the side2 of the triangle");
                        // Node F:
                        int b = int.Parse(Console.ReadLine());
                        // Node G:
                        Console.WriteLine($"Enter the side3 of the triangle ");
                        // Node H:
                        int c = int.Parse(Console.ReadLine());
                        // Node I:
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                        break;
                    }

                    // Node S:
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
        
    

