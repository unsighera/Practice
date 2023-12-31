﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Bicycle : Transport
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public bool IsRented { get; set; }
        public int CountOfWheels { get; set; }
        public string AdditionalFeature { get; set; }

        public Bicycle(string model, string color, int maxspeed, bool isrented, int countofwheels, string additionalfeature)
        {
            Model = model;
            Color = color;
            MaxSpeed = maxspeed;
            IsRented = isrented;
            CountOfWheels = countofwheels;
            AdditionalFeature = additionalfeature;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Bicycle - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Is Rented: {IsRented}, Count of Wheels: {CountOfWheels}, Additional Feature: {AdditionalFeature}");
        }
    }
}
