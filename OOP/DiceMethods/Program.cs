namespace DiceD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result = 0, throws = 0, faces = 0;
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

                Console.WriteLine($"\n*** {args[i]} ***");

                // a loop that throws the series
                // and keeps tally of the results
                for (int j = 0; j < throws; j++)
                {
                    // a single dice throw
                    result = rnd.Next(1, faces + 1);
                    dist[result - 1] = dist[result - 1] + 1;
                }

                // print the distribution
                for (int k = 0; k < dist.Length; k++)
                {
                    Console.WriteLine($"{k + 1}: {dist[k]}");
                }
            }
        }
    }
}
