

namespace ConsoleApp3
{
    public class Transmission
    {
        public string Type { get; }
        public string NumberOfGears { get; }
        public string Manufacturer { get; }

        public Transmission(string type, string numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }
        
        

        
    }
}