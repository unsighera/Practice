using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Scooter : Transport
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public bool IsRented { get; set; }
        public int CountOfWheels { get; set; }
        public string AdditionalFeature { get; set; }

        public Scooter(string model, string color, int maxspeed, bool isrented, int countofwheels, string additionalFeature)
        {
            Model = model;
            Color = color;
            MaxSpeed = maxspeed;
            IsRented = isrented;
            CountOfWheels = countofwheels;
            AdditionalFeature = additionalFeature;
        }
        public  void PrintInfo()
        {
            Console.WriteLine($"Scooter - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Is Rented: {IsRented}, Count of Wheels: {CountOfWheels}, Additional Feature: {AdditionalFeature}");
        }
    }
}
