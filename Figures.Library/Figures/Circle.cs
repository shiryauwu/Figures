using Figures.Library.Helpers;

namespace Figures.Library.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Инициализирует круг.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(double radius)
        {
            ValidationHelper.CheckIsNotPositive(radius);
            Radius = radius;
        }

        /// <summary>
        /// Возвращает площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double CountArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
