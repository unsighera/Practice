using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Bike : Transport
    {
        public override string Model { get; set; }
        public override string Color { get; set; }
        public override int MaxSpeed { get; set; }
        public override bool IsRented { get; set; }
        public string Category { get; set; }
        public int CountOfWheels { get; set; }
        public  string Motor { get; set; }
        public override string AdditionalFeature { get; set; }


        public Bike(string model, string color, int maxspeed, bool isrented, string category, int countofwheels, string motor, string additionalfeature)
        {
            Model = model;
            Color = color;
            MaxSpeed = maxspeed;
            IsRented = isrented;
            Category = category;
            CountOfWheels = countofwheels;
            Motor = motor;
            AdditionalFeature = additionalfeature;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Bike - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Category: {Category}, Is Rented: {IsRented}, Count of Wheels: {CountOfWheels}, Motor: {Motor}");
        }
    }
}
