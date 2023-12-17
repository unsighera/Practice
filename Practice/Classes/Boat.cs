using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Boat : Transport
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public bool IsRented { get; set; }
        public string Motor { get; set; }
        public string AdditionalFeature { get; set; }

        public Boat(string model, string color, int maxspeed, bool isrented, string motor, string additionalfeature)
        {
            Model = model;
            Color = color;
            MaxSpeed = maxspeed;
            IsRented = isrented;
            Motor = motor;
            AdditionalFeature = additionalfeature;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Boat - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Is Rented: {IsRented},  Motor: {Motor}, Additional Feature: {AdditionalFeature}");
        }
    }
}
