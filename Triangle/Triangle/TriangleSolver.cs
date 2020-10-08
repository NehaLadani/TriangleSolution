using System;

namespace Triangle
{
    //creating class
     public class TriangleSolver
    {
        // Creating method and passing parameters with return type string because the output of the program should return string.
        public static string Analyze(int a, int b, int c)
        {
            // Basic condition of a triangle - checks whether the given values form a triangle or not.
            // Node J:
            if (a + b > c && b + c > a && c + a > b == true)
            {
                // Prints - if the given values satisfies the condition.
                // Node K:
                Console.WriteLine($"It is a Triangle");

                // Condition checks whether the given values forms an Equilateral triangle - having all sides equal.
                // Node L:
                if (a == b && b == c && c == a)
                {
                    // Prints - if the given values satisfies the condition.
                    // It returns string, so return type is used.
                    // Node M:
                    return "It is an Equilateral Triangle";
                }

                // Condition checks whether the given values forms an Isosceles triangle - having any two sides equal.
                // Node N:
                else if (a == b || b == c || a == c)
                {
                    // Prints - if the given values satisfies the condition.
                    // Node O:
                    return "It is an Isosceles Triangle";
                }

                // If the condition becomes false - 
                // Node P:
                else
                {
                    // Then prints
                    return "It is a Scalene Triangle";
                } // Node Q:
            }
            // If the basic condition is not satisfied, then it directly prints that it is not a triangle.
            // Node R:
            else
            {
                return "It is not a Triangle";
            }
        }
    }
}


    

