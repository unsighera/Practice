using System;
using System.Collections.Generic;
using Practice.Classes;

Boat boat1 = new Boat("Submarine - S", "Blue", 50, false, "SPL-12D", "size 3m x 2m");
Boat boat2 = new Boat("Submarine - A", "Green", 42, false, "ATL-32Y", "size 6m x 3m");

Car car1 = new Car("Tesla Model S", "White", 300, true, "B", 4, "DAS-1F-FA", "The car has left-hand drive");
Car car2 = new Car("BMW M7 Competition", "Red", 250, true, "B", 4, "FAB-1L-FA", "The car has right-hand drive");

Bicycle bicycle1 = new Bicycle("BMX", "Black", 40, false, 2, "Stunt bike");
Bicycle bicycle2 = new Bicycle("MTB", "Pink", 45, false, 2, "Overroad stunt bike");

Bike bike1 = new Bike("Yamaha R8", "Pinkiy-Pie", 300, false, "M", 2, "GASR-124T", "Thing that is accompanied by the sound tu tu doo doo tutududutu");
Bike bike2 = new Bike("Alpha", "Red", 40, false, "M", 2, "NBJS-5F-FA", "Shit bike");

Scooter scooter1 = new Scooter("Xiaomi", "White", 25, false, 2, "Clever scooter");
Scooter scooter2 = new Scooter("Yezz", "Purple", 25, false, 2, "Regular scooter, u wouldn't see smth special, just don't see at that");
List<Transport> transports = new List<Transport>();
transports.Add(boat1);
transports.Add(boat2);
transports.Add(car1);
transports.Add(car2);
transports.Add(bicycle1);
transports.Add(bicycle2);
transports.Add(bike1);
transports.Add(bike2);
transports.Add(scooter1);
transports.Add(scooter2);
Console.WriteLine("List of all transports:");
Console.WriteLine("If u want to see the speeds, just write 'Show me speeds'");

foreach (var transport in transports)
{
    transport.PrintInfo();
}


while (true)
{
    if (Console.ReadLine() == "Show me speeds")
    {
        foreach (var transport in transports)
        {
            transport.CompareSpeeds(transports);
        }
    }
}

