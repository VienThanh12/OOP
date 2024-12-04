namespace part1
{
    public class Candidate
    {
        // Properties with default get and set methods: auto-implemented properties
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Party
        {
            get;
            set;
        }

        private int _votes;
        public int Votes
        {
            // make sure that the votes are not negative
            get
            {
                return _votes;
            }
            set
            {
               if(value >= 0)
                {
                    _votes = value;
                }
                else
                {
                    _votes = 0;
                }
            }
        }
        // Methods
        // Constructor
        public Candidate(string first, string last, string party, int votes) 
        {
            FirstName = first;
            LastName = last;
            Party = party;

            Votes = votes;
        }
        // Override ToString method 
        public override string ToString()
        {
            return $"{LastName}, {FirstName} ({Party}): {Votes}";
        }
    }
}