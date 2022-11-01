
namespace ConsoleApp3
{
    public class Engine
    {
        public string Power { get; }
        public string Volume { get; }
        public string Type { get; }
        public string Serial { get; }
        public string Number { get; }

        public Engine(string power, string volume, string type, string serial, string number)
        {
            Power = power;
            Volume = volume;
            Type = type;
            Serial = serial;
            Number = number;
        }
        
    }
}