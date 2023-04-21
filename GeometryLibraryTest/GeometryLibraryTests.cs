using Xunit;
using GeometryLibrary.Figures;

namespace GeometryLibraryTest
{
    public class FigureTests
    {
        [Fact]
        public void Circle_GetArea_ReturnsCorrectValue()
        {
            var circle = new Circle(5);

            Assert.Equal(78.53981633974483, circle.GetArea());
        }

        [Fact]
        public void Triangle_GetArea_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.Equal(6, triangle.GetArea());
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            var triangle = new Triangle(1, 2, 3);

            Assert.False(triangle.IsRightAngled());
        }
    }
}