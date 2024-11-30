namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Background for Example Shapes2:
            /* 
            List<int> list = new List<int> { 1, 5, 6, 3, 10, 9 };
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            */

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square(0, 0, 2));
            shapes.Add(new Circle(1, 1, 2));
            shapes.Add(new Square(-1, 3, 3));
            shapes.Add(new Circle(-1, 4, 4));
            shapes.Add(new Square(5, -2, 1));

            // backround for example Shapes2
            // shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

        }
    }
}
