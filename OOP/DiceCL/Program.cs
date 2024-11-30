/*
Create a C# program that simulates multiple series of
dice throws. The information on what kind of dice is
thrown and hoe many times is given in the command
line. For example, starting the program as follows
DiceCL 1d4 2d20
Means that a 4 sided dice is thrown 1 time and a 20
sided dice 2 times.
The program shows the results of each series in the
order they have been given in the command line. For
each series, the series information such as 1d4 is
shown followed by the result of each of the throws.
Finally, the lowers and highest result in the series is
shown.
*/
namespace DiceCL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result = 0, throws = 0, faces = 0, highest = 0, lowest = 0;

            // a loop that goes through the command line parameters
            // == series of the dice throws
            for (int i = 0; i < args.Length; i++)
            {
                // reset the highest and lowest result
                lowest = 0;
                highest = 0;

                // parse series information (number of throws and
                // the faces of the dice) from the command line parameter
                string[] tmp = args[i].Split('d');
                throws = int.Parse(tmp[0]);
                faces = int.Parse(tmp[1]);

                Console.WriteLine($"\n*** {args[i]} ***");

                // a loop that throws the series
                // and print the results
                for (int j = 0; j < throws; j++)
                {
                    // a single dice throw
                    result = rnd.Next(1, faces + 1);
                    Console.WriteLine(result);

                    // check if then result is lowest or
                    // highest in the series and if it is,
                    // update the corrresponding variables
                    if (lowest == 0 || result < lowest)
                    {
                        lowest = result;
                    }

                    if (result > highest)
                    {
                        highest = result;
                    }
                }
                Console.WriteLine($"Lowest: {lowest}");
                Console.WriteLine($"Highest: {highest}");
            }
        }
    }
}
