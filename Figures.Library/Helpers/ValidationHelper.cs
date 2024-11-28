using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Library.Helpers
{
    /// <summary>
    /// Валидатор.
    /// </summary>
    internal static class ValidationHelper
    {
        /// <summary>
        /// Проверяет число на отрицательность.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void CheckIsNotPositive(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}
