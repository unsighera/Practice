using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    public abstract class Transport
    {
        public abstract string Model { get; set; }
        public abstract string Color { get; set; }
        public abstract int MaxSpeed { get; set; }
        public abstract bool IsRented { get; set; }
        public int CountOfWheels { get; set; }
        public string Motor { get; set; }
        public abstract void PrintInfo();
    }
}
