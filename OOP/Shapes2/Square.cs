namespace Shapes
{
    public class Square : Shape
    {
        private int _side;
        public int Side
        {
            get { return _side; }
            set
            {
                if (value >= 1)
                {
                    _side = value;
                }
                else
                {
                    _side = 1;
                }
            }
        }

        public Square(int x, int y, int side) : base(x, y)
        {
            _side = side;
        }

        public override float CalculateArea()
        {
            return Side * Side;
        }

        // Example Shapes2
        /*
        public override int CompareTo(Shape other)
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
        */

        public override string ToString()
        {
            return $"Square at {base.ToString()} with side of {Side} and surface area of {CalculateArea()}";
        }
    }
}

