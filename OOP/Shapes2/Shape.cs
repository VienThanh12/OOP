namespace Shapes
{
    public abstract class Shape : IComparable<Shape> // Example Shapes2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract float CalculateArea();
        // Example Shapes2
        public int CompareTo(Shape other)
        {
            if (CalculateArea() < other.CalculateArea())
            {
                return -1;
            }
            else if (CalculateArea() > other.CalculateArea())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}

