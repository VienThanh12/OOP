namespace part2
{
    /*
     Implement two classes DoorSensor and TemperatureSensor in C# that both inherit
    (are child classes of the) class Sensor (the base class). */
    public class DoorSensor : Sensor
    {
        /*
         DoorSensor has property IsOpen (bool) having default get and set. 
        */
        public bool IsOpen
        {
            get;
            set;
        }
        /*
         Both classes should have feasible constructor and ToString method and implement the method CurrentStatus.
        */
        // Constuctor
        public DoorSensor(int serial, bool isOpen) : base(serial)
        {
            IsOpen = isOpen;
        }

        /*
         DoorSensor returns the status as either "Open" or "Closed" depending on the value of IsOpen property.
         */
        public override string CurrentStatus()
        {
            if(IsOpen == false)
            {
                return "Closed";
            }
            else
            {
                return "Open";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Status: {CurrentStatus()}";
        }
    }
}