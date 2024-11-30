namespace DiceMethods
{
    internal class Program
    {
        static int ThrowDice(int faces)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, faces + 1);
            return result;
        }

        static int[] ThrowSeries(int throws, int faces)
        {
            int[] dist = new int[faces];
            int result = 0;

            for (int i = 0; i < throws; i++)
            {
                result = ThrowDice(faces);
                dist[result - 1] = dist[result - 1] + 1;
            }

            return dist;
        }

        static void PrintDistribution(int[] dist)
        {
            for (int k = 0; k < dist.Length; k++)
            {
                Console.WriteLine($"{k + 1}: {dist[k]}");
            }
        }

        static void Main(string[] args)
        {
            
            int throws = 0, faces = 0;
            // the table for keeping tally of the dice throw results
            int[] dist;

            // a loop that goes through the command line parameters
            // == series of the dice throws
            for (int i = 0; i < args.Length; i++)
            {
                // parse series information (number of throws and
                // the faces of the dice) from the command line parameter
                string[] tmp = args[i].Split('d');
                throws = int.Parse(tmp[0]);
                faces = int.Parse(tmp[1]);

                // create a table of correct size for current series
                dist = new int[faces];

                // throw the series using method
                dist = ThrowSeries(throws, faces);

                Console.WriteLine($"\n*** {args[i]} ***");
                // print the distribution using a method
                PrintDistribution(dist);
            }
        }
    }
}
