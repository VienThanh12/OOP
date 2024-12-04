namespace part2
{
    /*
     Implement two classes DoorSensor and TemperatureSensor in C# that both inherit
    (are child classes of the) class Sensor (the base class). */
    public class TemperatureSensor : Sensor
    {
        /*
        TemperatureSensor has property Temperature (double) having default get and set.
         */
        public double Temperature { get; set; }

        /*
         Both classes should have feasible constructor and ToString method and implement the method CurrentStatus.
         */
        // Constructor
        public TemperatureSensor(int serial, double temperature) : base(serial)
        {
            Temperature = temperature;
        }
        // Implement CurrentStatus
        /*
         TemperatureSensor returns the status as a string having the value of Temperature property added by
        "(Celsius)", for example "6.5 (Celsius)".
         */
        public override string CurrentStatus()
        {
            return $"{Temperature} (Celsius)";
        }

        // ToString method
        public override string ToString()
        {
            return $"{base.ToString()}, Temperature: {CurrentStatus()}";
        }
    }
}