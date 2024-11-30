namespace Shapes
{
    public abstract class Shape
    {
        // Properties
        // auto-implemented X and Y
        public int X { get; set; }
        public int Y { get; set; }

        // constructor
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        // abstract method
        public abstract double CalculateArea();

        // ToString-method
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
