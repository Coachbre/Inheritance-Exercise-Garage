using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla is cruising. *Silence*");
        }

          public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla does not really have breaks. Good luck!");
        } 
        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
