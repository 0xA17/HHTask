namespace GeometryLibrary.Figures
{
    public class Circle : Figure
    {
        public Double Radius { get; set; }

        public Circle(Double radius)
        {
            Radius = radius;
        }

        public Double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}