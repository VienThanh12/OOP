/*
Create a C# program simulating throwing a 6 sided dice 3 times in a
row (”3d6”). The program shows the result of each of the throws as
well as the number of sixes (”None”, 1, 2 or 3).
*/
namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int sixes = 0;
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                result = rnd.Next(1, 7);
                Console.WriteLine(result);

                if (result == 6)
                {
                    sixes++;
                }
            }

            Console.WriteLine("Number of sixes:");

            if (sixes == 0)
            {
                Console.WriteLine("None");
            } else
            {
                Console.WriteLine(sixes);
            }
        }
    }
}
