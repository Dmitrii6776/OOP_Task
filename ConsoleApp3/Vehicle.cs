using System;

namespace ConsoleApp3
{
    public class Vehicle
    {
        private readonly string _vehicleName;
        private readonly Transmission _transmission;
        private readonly Chassis _chassis;
        private readonly Engine _engine;

        public Vehicle(string name, Transmission transmission, Chassis chassis, Engine engine)
        {
            _vehicleName = name;
            _transmission = transmission;
            _chassis = chassis;
            _engine = engine;
        }

        public void GetName()
        {
            Console.WriteLine("Vehicle name:" + _vehicleName);
            Console.WriteLine();
        }
        

        public void GetTransmissionData()
        {
            Console.WriteLine("Transmission info:");
            Console.WriteLine("Type: " + _transmission.Type);
            Console.WriteLine("Number Of Gears: " + _transmission.NumberOfGears);
            Console.WriteLine("Manufacturer: " + _transmission.Manufacturer);
            Console.WriteLine();
            
        }
        
        public void GetEngineData()
        {
            Console.WriteLine("Engine Info: ");
            Console.WriteLine("Power: " + _engine.Power);
            Console.WriteLine("Volume: " + _engine.Volume);
            Console.WriteLine("Type: " + _engine.Type);
            Console.WriteLine("Serial: " + _engine.Serial);
            Console.WriteLine("Number: " + _engine.Number);
            Console.WriteLine();
        }
        
        public void GetChassisData()
        {
            Console.WriteLine("Chassis info: ");
            Console.WriteLine("Wheels Number: " + _chassis.WheelsNumber);
            Console.WriteLine("Number: " + _chassis.Number);
            Console.WriteLine("Permissible Load: " + _chassis.PermissibleLoad);
            Console.WriteLine();
        }
    }
}