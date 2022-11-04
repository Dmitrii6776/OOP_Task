
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using ConsoleApp3;

List<Vehicle> vehicles = new();
string? vehiclesByTrType = null;
string PATH = "/Users/dmitrijposin/RiderProjects/ConsoleApp3/ConsoleApp3/";

XMLWriteDocument engineVolume = new XMLWriteDocument($"{PATH}engineVolume.xml");
XMLWriteDocument truckAndBus = new XMLWriteDocument($"{PATH}truckAndBus.xml");
XMLWriteDocument groupByType = new XMLWriteDocument($"{PATH}groupByType.xml");


Vehicle passengerCar  = new("Passenger car", 
    new Transmission("Mechanic", "5", "Ford"),
    new Chassis("4", "1341234", "2.1"),
    new Engine("120", 1.4f, "Gasoline", "234242", "2453"));
Vehicle truck  = new("Truck", 
    new Transmission("Automatic", "6", "Chevrolet"),
    new Chassis("4", "6", "3"),
    new Engine("240", 2.0f, "Diesel", "ddfgf34", "34r8u"));
Vehicle bus  = new("Bus", 
    new Transmission("Mechanic", "6", "Mercedes"),
    new Chassis("4", "343fb3", "5"),
    new Engine("160", 3.0f, "Gas", "234i45ht242", "3hkbti5"));
Vehicle scooter  = new("Scooter", 
    new Transmission("Automatic", "3", "Suzuki"),
    new Chassis("2", "3rf", "6"),
    new Engine("50", 0.5f, "Electric", "234242", "1"));

vehicles.Add(passengerCar);
vehicles.Add(truck);
vehicles.Add(bus);
vehicles.Add(scooter);

var vehicleGroupByTransmissionType = vehicles.GroupBy(auto => auto.Transmission.Type);

foreach (var vehicle in vehicles)
{
    if (vehicle.Engine.Volume > 1.5f)
    {
        var content = $"{vehicle.GetName()} \n" +
                      $"{vehicle.GetChassisData()}" +
                      $"{vehicle.GetEngineData()}" +
                      $"{vehicle.GetTransmissionData()}";
        engineVolume.Write(content);

    }

    if (vehicle.GetName() == "Truck" || vehicle.GetName() == "Bus")
    {
        var content = $"{vehicle.GetName()} \n" +
                      $"{vehicle.Engine.Type}" +
                      $"{vehicle.Engine.Number}" +
                      $"{vehicle.Engine.Power}";
        truckAndBus.Write(content);
        
    }
}

foreach (var group in vehicleGroupByTransmissionType)
{
    vehiclesByTrType = $"{group.Key} : \n";
    groupByType.Write(vehiclesByTrType);
    
        
    foreach (var vehicle1 in group)
    {
        vehiclesByTrType = $"{vehicle1.GetName()} \n" +
                            $"{vehicle1.GetChassisData()}" +
                            $"{vehicle1.GetEngineData()}" +
                            $"{vehicle1.GetTransmissionData()}";
         groupByType.Write(vehiclesByTrType);
        

    }
}

