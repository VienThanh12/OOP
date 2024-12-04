namespace part2
{
    /*
     * Create a program (Main method in class Program2) in C# 
     */
    internal class Program2
    {
        static void Main(string[] args)
        {
            // creates a List whose elements are instances of the class Sensor. 
            List<Sensor> sensors = new List<Sensor>();


            // Create at least 6 instances of the class having both DoorSensors and TemperatureSensors
            sensors.Add(new DoorSensor(122222, true));
            sensors.Add(new DoorSensor(122221, true));
            sensors.Add(new DoorSensor(122220, true));
            sensors.Add(new DoorSensor(122212, true));

            sensors.Add(new DoorSensor(922212, true));
            sensors.Add(new DoorSensor(9, true)); // Testing with small number
            sensors.Add(new DoorSensor(-9, true)); // Testing with negative number

            sensors.Add(new TemperatureSensor(123344, -6.5));
            sensors.Add(new TemperatureSensor(123342, -12.5));
            sensors.Add(new TemperatureSensor(123343, -10.5));
            sensors.Add(new TemperatureSensor(99999, -10.5)); // Testing with < 100000 number
            sensors.Add(new TemperatureSensor(100000, -10.5)); // Testing the limit
            sensors.Add(new TemperatureSensor(999999, -10.5)); // Testing the limit
            sensors.Add(new TemperatureSensor(1000000, -10.5)); // Testing with > 999999 number
            // Sort the List
            sensors.Sort();
            /*
             Finally, create a loop that iterates through the sorted List and prints the information 
             of Sensor using the ToString method of the class in question.
             */
            foreach (Sensor sensor in sensors)
            {
                Console.WriteLine(sensor);
            }
        }
    }
}