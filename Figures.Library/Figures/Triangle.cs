using Figures.Library.Helpers;

namespace Figures.Library.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Сторона A.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Сторона B.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Сторона C.
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Периметр.
        /// </summary>
        public double Perimeter { get; set; }

        /// <summary>
        /// Треугольник прямоугольный.
        /// </summary>
        public bool IsRight { get; set; }

        /// <summary>
        /// Инициализирует треугольник.
        /// </summary>
        /// <param name="sideA">Сторона A.</param>
        /// <param name="sideB">Сторона B.</param>
        /// <param name="sideC">Сторона C.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidationHelper.CheckIsNotPositive(sideA);
            ValidationHelper.CheckIsNotPositive(sideB);
            ValidationHelper.CheckIsNotPositive(sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Perimeter = sideA + sideB + sideC;

            var sides = new double[] { sideA, sideB, sideC };
            Array.Sort(sides);

            IsRight = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        /// <summary>
        /// Возвращает площадь треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double CountArea()
        {
            double halfPerimeter = Perimeter / 2;

            return Math.Sqrt(halfPerimeter *
                (halfPerimeter - SideA) *
                (halfPerimeter - SideB) *
                (halfPerimeter - SideC));
        }
    }
}
