using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna is driving. Zoooooom!");
        }

         public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna turns {direction} for no reason!");
        }

          public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop on the runway. Oh no!");
        }
    }
}
