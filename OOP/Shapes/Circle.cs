using System.Drawing;

namespace Shapes
{
    public class Circle : Shape
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value >= 1)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 1;
                }
            }
        }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string ToString()
        {
            return $"Circle at {base.ToString()} with radius of {Radius} and surface area of {CalculateArea()}";
        }
    }
}
