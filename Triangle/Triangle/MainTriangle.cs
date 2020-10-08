using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Triangle
{
    // Creating class
     public class MainTriangle
    {
        // Main method
        public static void Main()
        {
            // Exception Handling - If entering double value instead of integers.
            try
            {
                // Checks the condition for the infinity loop.
                while (true)
                {
                    // Prints the line
                    Console.WriteLine($"1. Enter Triangle Dimensions ");
                    // Prints the line
                    Console.WriteLine($"2. Exit");

                    // Initialize the variable for the user input.
                    // Node A:
                    int i = int.Parse(Console.ReadLine());

                    // Condition for the infinity loop. 
                    // If user enters input value as '1' then the condition satisfies and performs the condition.
                    // Node B:
                    if (i == 1)
                    {
                        // Prints the line.
                        // Node C;
                        Console.WriteLine($"Enter the side1 of the triangle ");
                        // User can input side1 of the triangle value.
                        // Node D:
                        int a = int.Parse(Console.ReadLine());

                        // Prints the line
                        // Node E:
                        Console.WriteLine($"Enter the side2 of the triangle");
                        // User can input side2 of the triangle value.
                        // Node F:
                        int b = int.Parse(Console.ReadLine());

                        // Prints the line
                        // Node G:
                        Console.WriteLine($"Enter the side3 of the triangle ");
                        // User can input side3 of the triangle value.
                        // Node H:
                        int c = int.Parse(Console.ReadLine());

                        // Call the Analyze method to print which triangle satisfies the given value and displays the kind of the triangle accordingly.
                        // Node I:
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));

                        // Procedure stops
                        break;
                    }

                    // Exit
                    // Node S:
                    else if (i == 2)
                    {
                        break;
                    }
                }
            }
            // Exception Handling and prints the reason about what's wrong.
            catch
            {
                Console.WriteLine($"Dimensions entered are incorrect");
            }

        }
    }
}
        
    

