using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Scooter : Transport
    {
        public override string Model { get; set; }
        public override string Color { get; set; }
        public override int MaxSpeed { get; set; }
        public override bool IsRented { get; set; }
        public int CountOfWheels { get; set; }
        public Scooter(string model, string color, int maxspeed, bool isrented, int countofwheels)
        {
            Model = model;
            Color = color;
            MaxSpeed = maxspeed;
            IsRented = isrented;
            CountOfWheels = countofwheels;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Scooter - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Is Rented: {IsRented}, Count of Wheels: {CountOfWheels}");
        }
    }
}
