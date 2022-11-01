

namespace ConsoleApp3
{
    public class Chassis
    {
        public string WheelsNumber { get; }
        public string Number { get; }
        public string PermissibleLoad { get; }

        public Chassis(string wheelsNumber, string number, string permissibleLoad)
        {
            Number = number;
            WheelsNumber = wheelsNumber;
            PermissibleLoad = permissibleLoad;
        }
        
    }
}