namespace Shapes
{
    public class Circle : Shape, IDrawable // Example Shapes2
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
            _radius = radius;
        }

        public override float CalculateArea()
        {
            return (float)(Math.PI * (Radius * Radius));
        }

        // Example Shapes2
        public void Draw()
        {
            Console.WriteLine($"Circle ({base.ToString()})");
        }

        public override string ToString()
        {
            return $"Circle at {base.ToString()} with radius of {Radius} and surface area of {CalculateArea()}";
        }
    }
}
