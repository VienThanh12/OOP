namespace part2
{
    // Implement an abstract class Sensor in C#. 
    public abstract class Sensor : IComparable<Sensor>  
    {
        /*
        It should have implemented property Serial (int) having the default get and set that
        checks that the Serial is greater or equal to 100000 but less or equal 999999 and if it is not,
        the method should set the Serial to -1
        */
        public int _serial;
        public int Serial
        {
            get
            {
                return _serial;
            }
            set
            {
                if(value >= 100000 && value <= 999999)
                {
                    _serial = value;
                }
                else
                {
                    _serial = -1;
                }
            }
        }
        /*
        The class should also have an abstract method CurrentStatus that returns a string.
        */
        public abstract string CurrentStatus();

        /*
          Implement feasible constructor.
         */
        // constructor
        public Sensor(int serial)
        {
            Serial = serial;
        }
        /*
         ToString method for the class
         */
        public override string ToString()
        {
            return $"Sensor Serial: {Serial}";
        }
        // Implement IComparable
        /*
         Make your classes comparable by implementing interface IComparable.
        The comparison should be based on the value of the property Serial (ascending order).
         */
        public int CompareTo(Sensor other)
        {
            if (other == null) return 1;
            return this.Serial.CompareTo(other.Serial);
        }
    }
}