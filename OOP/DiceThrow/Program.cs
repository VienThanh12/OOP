namespace DiceObject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example DiceThrows
            // b)
            Dice[] series = new Dice[5];
            Dice dice;

            for (int i = 0; i < series.Length; i++)
            {
                dice = new Dice(8);
                dice.Throw();
                series[i] = dice;
            }

            foreach (Dice d in series)
            {
                // Console.WriteLine(d);
                Console.WriteLine(d.Result);
            }

            // a)
            /*
            Dice dice3 = new Dice(8);
            int[] series = new int[5];

            for (int i = 0; i < series.Length; i++)
            {
                dice3.Throw();
                series[i] = dice3.Result;
            }

            foreach (int result in series)
            {
                Console.WriteLine(result);
            }
            */

            // Example DiceObject2
            /*
            Dice dice1 = new Dice();
            dice1.Throw();
            Console.WriteLine(dice1.Faces);
            Console.WriteLine(dice1.Result);
            Console.WriteLine(dice1);

            Dice dice2 = new Dice(20);
            dice2.Throw();
            Console.WriteLine(dice2);
            */
        }
    }
}
