using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                MainColor = "green",
                MaximumOccupancy = 1,
            };

            Tesla modelS = new Tesla()
             {
                MainColor = "yellow",
                MaximumOccupancy = 5,
            };

            Cessna mx410 = new Cessna()
             {
                MainColor = "red",
                MaximumOccupancy = 3,
            };
            
            Ram idk3000 = new Ram()
             {
                MainColor = "blue",
                MaximumOccupancy = 4,
            };

            fxs.Drive(); 
            modelS.Drive();
            mx410.Drive();
            idk3000.Drive();
        }
    }
}