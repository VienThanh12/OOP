using System.ComponentModel.Design;

namespace LoadedDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example DiceThrows2
            // list containing Dice instances
            List<Dice> series = new List<Dice>();
            Dice dice = new Dice();

            // create 5 dice, throw each of them and add them to the list
            for (int i = 0; i < 5; i++)
            {
                if (i < 3)
                {
                    // three first are (normal) Dice instances
                    dice = new Dice(8);
                }
                else
                {
                    // two last are LoadedDice instances
                    dice = new LoadedDice(20);
                }
                // throw the created die and add it to the (end) of the list
                dice.Throw();
                series.Add(dice);
            }

            // go through the list and print the status of the dice instances
            foreach (Dice d in series)
            {
                Console.WriteLine(d);
            }

            /*
            Dice dice = new Dice();
            dice.Throw();
            Console.WriteLine(dice);

            LoadedDice loadedDice1 = new LoadedDice();
            loadedDice1.Throw();
            Console.WriteLine(loadedDice1);

            LoadedDice loadedDice2 = new LoadedDice(20);
            loadedDice2.Throw();
            Console.WriteLine(loadedDice2);

            LoadedDice loadedDice3 = new LoadedDice(8, 1);
            loadedDice3.Throw();
            Console.WriteLine(loadedDice3);
            */
        }
    }
}
