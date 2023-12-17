using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice.Classes
{
    public interface Transport
    {
        public abstract string Model { get; set; }
        public abstract string Color { get; set; }
        public abstract int MaxSpeed { get; set; }
        public abstract bool IsRented { get; set; }
        public abstract void PrintInfo();

        public virtual void CompareSpeeds(List<Transport> transports) { }
        public virtual void CheckRentalStatus() { }
    }
}
