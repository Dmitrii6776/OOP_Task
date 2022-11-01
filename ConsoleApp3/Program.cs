
using System.Collections.Generic;
using ConsoleApp3;

List<Vehicle> vehicles = new List<Vehicle>();

Vehicle passengerCar  = new("Passenger car", 
    new Transmission("Automatic", "6", "Ford"),
    new Chassis("4", "6", "2.1"),
    new Engine("120", "240", "Gasoline", "234242", "1"));
Vehicle truck  = new("Truck", 
    new Transmission("Automatic", "6", "Ford"),
    new Chassis("4", "6", "2.1"),
    new Engine("120", "240", "Gasoline", "234242", "1"));
Vehicle bus  = new("Bus", 
    new Transmission("Automatic", "6", "Ford"),
    new Chassis("4", "6", "2.1"),
    new Engine("120", "240", "Gasoline", "234242", "1"));
Vehicle scooter  = new("Scooter", 
    new Transmission("Automatic", "6", "Ford"),
    new Chassis("4", "6", "2.1"),
    new Engine("120", "240", "Gasoline", "234242", "1"));

vehicles.Add(passengerCar);
vehicles.Add(truck);
vehicles.Add(bus);
vehicles.Add(scooter);

foreach (var vehicle in vehicles)
{
    vehicle.GetName();
    vehicle.GetChassisData();
    vehicle.GetEngineData();
    vehicle.GetTransmissionData();
}