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
            //fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            //modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            idk3000.Drive();
            //idk3000.Turn();
            idk3000.Stop();
        }
    }
}