

using Figures.Library.Figures;

namespace Figures.Library.Tests
{
    /// <summary>
    /// Тесты круга.
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Проверяет входные параметры на положительность.
        /// </summary>
        [Fact]
        public void Circle_InvalidRadiusLength_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Circle(-1)
            );
        }

        /// <summary>
        /// Проверяет вычисление площади на корректность.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <param name="area">Ожидаемая площадь.</param>
        [Theory]
        [InlineData( 1, Math.PI )]
        [InlineData( 5, 78.5)]
        [InlineData(8, 201)]
        public void Circle_Area_CorrectlyCalculated(double radius, double area)
        {
            var circle = new Circle(radius);

            var result = circle.CountArea();

            Assert.Equal(result, area, 0.1 );
        }
    }
}
