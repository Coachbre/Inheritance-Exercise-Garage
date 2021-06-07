using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public void Turn()
        {
            Console.WriteLine("The vehicle makes very wide turns.");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle stops abruptly.");
        }

    }
}
