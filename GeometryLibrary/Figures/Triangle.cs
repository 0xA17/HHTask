namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Сторона A.
        /// </summary>
        public Double SideA { get; set; }

        /// <summary>
        /// Сторона B.
        /// </summary>
        public Double SideB { get; set; }

        /// <summary>
        /// Сторона C.
        /// </summary>
        public Double SideC { get; set; }

        /// <summary>
        /// Создает экземпляр треугольника.
        /// </summary>
        /// <param name="a">Сторона А.</param>
        /// <param name="b">Сторона B.</param>
        /// <param name="c">Сторона С.</param>
        public Triangle(Double a, Double b, Double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        /// <summary>
        /// Получить площадь треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public Double GetArea()
        {
            Double s = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True - является прямоугольным, иначе - False.</returns>
        public Boolean IsRightAngled()
        {
            var sides = new Double[] { SideA, SideB, SideC };

            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}