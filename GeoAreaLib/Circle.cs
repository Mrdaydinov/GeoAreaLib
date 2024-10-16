namespace GeoAreaLib
{
    public class Circle : IFigure
    {
        private readonly double _rad;

        public Circle(double rad)
        {
            if (rad < 0)
                throw new ArgumentException("Радиус не может принимать отрицательные значения");
            _rad = rad;
        }

        public double GetArea()
        {
            return Math.PI * _rad * _rad;
        }
    }
}
