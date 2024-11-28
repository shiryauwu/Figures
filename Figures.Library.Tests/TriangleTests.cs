using Figures.Library.Figures;

namespace Figures.Library.Tests
{
    /// <summary>
    /// Тесты треугольника.
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// Проверяет периметр.
        /// </summary>
        [Fact]
        public void Triangle_Perimeter_CorrectlyCalculated()
        {
            var triangle = new Triangle(3, 4, 5);

            var perimeter = triangle.Perimeter;

            Assert.Equal(12, perimeter);
        }

        /// <summary>
        /// Проверяет вычисление площади.
        /// </summary>
        [Fact]
        public void Triangle_Area_CorrectlyCalculated()
        {
            var triangle = new Triangle(3, 4, 5);

            var area = triangle.CountArea();

            Assert.Equal(6, area, 0.01);
        }

        /// <summary>
        /// Проверяет прямоугольный треугольник.
        /// </summary>
        /// <param name="input">Входные параметры треугольника.</param>
        /// <param name="expected">Ожидаемый результат.</param>
        [Theory]
        [InlineData(new int[] { 3, 4, 5}, true)]
        [InlineData(new int[] { 5, 12, 13}, true)]
        public void Triangle_IsRight_CorrectlyIdentified(int[] input, bool expected)
        {
            var triangle = new Triangle(input[0], input[1], input[2]);

            var isRight = triangle.IsRight;

            Assert.Equal(isRight, expected);
        }

        /// <summary>
        /// Проверяет неправильный ввод параметров.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        [Theory]
        [InlineData(-1, 2, 3)]
        [InlineData(1, -2, 3)]
        [InlineData(1, 2, -3)]
        public void Triangle_InvalidSideLength_ThrowsArgumentOutOfRangeException(double sideA, double sideB, double sideC)
        {

            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Triangle(sideA, sideB, sideC)
            );
        }

        /// <summary>
        /// Проверяет непрямоугольный треугольник.
        /// </summary>
        [Fact]
        public void Triangle_IsNotRight_IdentifiedCorrectly()
        {
            var triangle = new Triangle(3, 4, 6);

            var isRight = triangle.IsRight;

            Assert.False(isRight);
        }
    }
}
