namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public Double Radius { get; set; }

        /// <summary>
        /// Создает экземпляр круга.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(Double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Получить площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public Double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}