/*
The goal is to make sure you know basics of implementing and using a class and using a class, creating and using OO classes
that have ralationships between them and that you know how to implement an interface
 */
namespace part1
{
    public class Program1
    {
        static void Main(string[] args)
        {
            // PART 1 A
            Console.WriteLine("Activity 1a");
            Candidate candi = new Candidate("Jane", "Douglas", "Oxbox", 12724);
            Console.WriteLine(candi);

            // PART 1 B

            Console.WriteLine("Activity 1b");

            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate("Jane", "Douglas", "Oxbox", 12724));
            candidates.Add(new Candidate("Ellen", "Rose", "Oxtra", 10214));
            candidates.Add(new Candidate("Luke", "Westaway", "Oxtra", 9011));
            candidates.Add(new Candidate("Andy", "Farrant", "Oxbox", 13319));
            candidates.Add(new Candidate("Mike", "Channel", "Oxbox", 8953));
            candidates.Add(new Candidate("Johnny", "Chiodini", "Oxventure", 10466));
            foreach (Candidate candidate in candidates)
            {   
                Console.WriteLine(candidate);
            }
        }
    }
}