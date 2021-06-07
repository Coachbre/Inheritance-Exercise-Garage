using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine("The Yellow Ram is growling. Grrrr!");
        } 
        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}
