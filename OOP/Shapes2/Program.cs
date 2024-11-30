namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square(0, 0, 2));
            shapes.Add(new Circle(1, 1, 2));
            shapes.Add(new Square(-1, 3, 3));
            shapes.Add(new Circle(-1, 5, 4));
            shapes.Add(new Square(5, -2, 1));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            // Shapes2
            Console.WriteLine("\n*** Sort ****\n");

            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            // Shapes2 - background
            /*
            Console.WriteLine("\n*** Backround ****\n");
            List<int> list = new List<int> { 1, 10, 6, 2, 7, 9 };
            list.Sort();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            */
        }
    }
}

