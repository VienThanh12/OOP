namespace DiceObject
{
    public class Dice
    {
        // attributes == class variables
        private int faces;
        private int result;
        private Random rnd;

        // methods

        // constructors
        public Dice()
        {
            faces = 6;
            result = 0;
            rnd = new Random();
        }

        public Dice(int faces)
        {
            if (faces >= 1)
            {
                this.faces = faces;
            }
            else
            {
                this.faces = 6;
            }

            result = 0;
            rnd = new Random();
        }

        public void Throw()
        {
            result = rnd.Next(1, faces + 1);
        }

        // ToString method for getting the string
        // representation of the class, for example
        // for printing
        public override string ToString()
        {
            return $"Dice: d{faces}, result: {result}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice();
            Console.WriteLine(dice1);
            dice1.Throw();
            Console.WriteLine(dice1);

            Dice dice2 = new Dice(20);
            Console.WriteLine(dice2);
            dice2.Throw();
            Console.WriteLine(dice2);

            Console.WriteLine("************");

            for (int i = 0; i < 5; i++)
            {
                dice1.Throw();
                Console.WriteLine(dice1);

                dice2.Throw();
                Console.WriteLine(dice2);
            }
        }
    }
}
