﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public class Car : Transport
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public bool IsRented { get; set; }
        public string Category { get; set; }
        public int CountOfWheels { get; set; }
        public string Motor { get; set; }
        public string AdditionalFeature { get; set; }

        public Car(string model, string color, int maxspeed, bool isrented,string category, int countofwheels, string motor, string additionalfeature)
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
        public void PrintInfo()
        {
            Console.WriteLine($"Car - Model: {Model}, Color: {Color}, Max Speed: {MaxSpeed}, Category: {Category}, Is Rented: {IsRented}, Count of Wheels: {CountOfWheels}, Motor: {Motor}, Additional Feature: {AdditionalFeature}");
        }
    }
}
