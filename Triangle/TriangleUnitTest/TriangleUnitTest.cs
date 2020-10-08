using NUnit.Framework;
using Triangle;

namespace TriangleUnitTest
{
    public class TriangleUnitTest
    {
        [TestFixture]
        public class TriangleTest
        {
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

        }
    }
}
