namespace GeoAreaLib.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_ValidSides_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea(), 10);
        }

        [Fact]
        public void Constructor_InvalidSides_ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
            Assert.Equal("Некорректные стороны треугольника", exception.Message);
        }

        [Fact]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void IsRightTriangle_InvalidTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(5, 6, 7);
            Assert.False(triangle.IsRightTriangle());
        }
    }
}
