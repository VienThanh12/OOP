namespace Shapes
{
    public class Square : Shape
    {
        // field _side
        private int _side;

        // property Side
        // manual implementation
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

        // constructor
        public Square(int x, int y, int side) : base(x, y)
        {
            Side = side;
        }

        // implementation of the abstract method
        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return $"Square at {base.ToString()} with side of {Side} and surface area of {CalculateArea()}";
        }
    }
}
