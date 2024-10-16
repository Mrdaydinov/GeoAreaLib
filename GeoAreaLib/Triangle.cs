namespace GeoAreaLib
{
    public class Triangle : IFigure
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        public Triangle(double x, double y, double z)
        {
            if (x <= 0 || y <= 0 || z <= 0)
                throw new ArgumentException("Стороны не могут принимать отрицательные значения");
            if (x + y <= z || x + z <= y || y + z <= x)
                throw new ArgumentException("Некорректные стороны треугольника");
            _x = x;
            _y = y;
            _z = z;
        }

        public double GetArea()
        {
            double s = (_x + _y + _z) / 2;
            return Math.Sqrt(s * (s - _x) * (s - _y) * (s - _z));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { _x, _y, _z };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}