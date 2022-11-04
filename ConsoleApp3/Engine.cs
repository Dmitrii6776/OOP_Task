
namespace ConsoleApp3
{
    public class Engine
    {
        public string Power { get; }
        public float Volume { get; }
        public string Type { get; }
        public string Serial { get; }
        public string Number { get; }

        public Engine(string power, float volume, string type, string serial, string number)
        {
            Power = power;
            Volume = volume;
            Type = type;
            Serial = serial;
            Number = number;
        }
        
    }
}