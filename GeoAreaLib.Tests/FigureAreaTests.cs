using Moq;

namespace GeoAreaLib.Tests
{
    public class FigureAreaTests
    {
        [Fact]
        public void CalculateArea_UsingMock_ReturnsCorrectArea()
        {
            var mockFigure = new Mock<IFigure>();
            mockFigure.Setup(f => f.GetArea()).Returns(42.0);

            var figureArea = new FigureArea();

            var area = figureArea.CalculateArea(mockFigure.Object);

            Assert.Equal(42.0, area);
        }
    }
}