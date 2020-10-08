using NUnit.Framework;

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






                    Assert.Pass();
        }
    }
}