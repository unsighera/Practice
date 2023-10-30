using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Boat : Transport
    {
        public override string Model { get; set; }
        public override string Color { get; set; }
        public override int MaxSpeed { get; set; }
        public override bool IsRented { get; set; }
        public string Motor { get; set; }
        public override string AdditionalFeature { get; set; }

        public Boat(string model, string color, int maxspeed, bool isrented, string motor, string additionalfeature)
        {
            Model = model;
            Color = color;
            MaxSpeed = maxspeed;
            IsRented = isrented;
            Motor = motor;
            AdditionalFeature = additionalfeature;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Boat - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Is Rented: {IsRented},  Motor: {Motor}");
        }
    }
}
