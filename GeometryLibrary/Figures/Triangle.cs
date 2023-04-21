namespace GeometryLibrary.Figures
{
    public class Triangle : Figure
    {
        public Double SideA { get; set; }
        public Double SideB { get; set; }
        public Double SideC { get; set; }

        public Triangle(Double a, Double b, Double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public Double GetArea()
        {
            Double s = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public Boolean IsRightAngled()
        {
            var sides = new Double[] { SideA, SideB, SideC };

            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}