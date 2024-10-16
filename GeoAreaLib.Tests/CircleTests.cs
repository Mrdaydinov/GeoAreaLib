namespace GeoAreaLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_ValidRadius_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            Assert.Equal(78.53981633974483, circle.GetArea(), 10);
        }

        [Fact]
        public void Constructor_NegativeRadius_ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(-1));
            Assert.Equal("Радиус не может принимать отрицательные значения", exception.Message);
        }
    }
}
