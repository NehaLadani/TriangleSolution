using NUnit.Framework;
using Triangle;

namespace TriangleUnitTest
{
    public class TriangleUnitTest
    {
        [TestFixture]
        public class TriangleTest
        {
            // To check whether the given integers form an Equilateral triangle. 
            [Test]
            public void Analyze_Input3and3and3_Output()
            {
                //Arrange
                int a = 3;
                int b = 3;
                int c = 3;
                string expectedResult = "It is an Equilateral Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.Pass(expectedResult, actualResult);
            }

            // To check whether the given integers form an Isosceles triangle.
            [Test]
            public void Analyze_Input4and4and6_Output()
            {
                //Arrange
                int a = 4;
                int b = 4;
                int c = 6;
                string expectedResult = "It is an Isosceles Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            // To check whether the given integers form a Scalene triangle.
            [Test]
            public void Analyze_Input4and5and6_Output()
            {
                //Arrange
                int a = 4;
                int b = 5;
                int c = 6;
                string expectedResult = "It is a Scalene Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            // To check whether the given integers of value '0' should not form a traingle.
            [Test]
            public void Analyze_Input0and0and6_Output()
            {
                //Arrange
                int a = 0;
                int b = 0;
                int c = 6;
                string expectedResult = "It is not a Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);

            }

            // To check whether the given integers of negative value should not form a triangle.
            [Test]
            public void  Analyze_Input6and6and6_Output()
            {
                //Arrange
                int a = -6;
                int b = -6;
                int c = -6;
                string expectedResult = "It is not a Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            // To check whether the given random integers should not form a triangle.
            [Test]
            public void Analyze_Input100and50and5_Output()
            {
                //Arrange
                int a = 100;
                int b = 50;
                int c = 5;
                string expectedResult = "It is not a Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

           // To check whether the given combination of both positive and negative integers should not form a triangle.
            [Test]
            public void Analyze_Input99and008and66_Output()
            {
                //Arrange
                int a = +99;
                int b = +008;
                int c = -66;
                string expectedResult = "It is not a Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            // To check whether the given integers starting with '00'should form a triangle of its kind.
            [Test] 
            public void Analyze_Input005and008and005_Output()
            {
                //Arrange
                int a = 005;
                int b = 008;
                int c = 005;
                string expectedResult = "It is an Isosceles Triangle";

                //Act
                string actualResult = TriangleSolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

        }
    }
}
