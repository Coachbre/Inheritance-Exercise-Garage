using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public override void Drive()
        {
            Console.WriteLine("The Blue Zero is flying. Shhhhh!");
        }        
        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
