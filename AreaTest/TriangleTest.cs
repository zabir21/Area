using Area;
using Xunit;

namespace AreaTest
{
    public class TriangleVTest
    {
        [Theory]
        [InlineData(3, 4, 5, true)] 
        [InlineData(5, 5, 5, true)] 
        [InlineData(2, 3, 6, false)] 
        [InlineData(1, 1, 1, true)] 
        public void TestIsTriangleValid(double side1, double side2, double side3, bool expected)
        {
            // Act
            bool actual = Function.IsTriangleValid(side1, side2, side3);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}