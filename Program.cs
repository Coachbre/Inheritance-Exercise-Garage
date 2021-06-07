using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram idk3000 = new Ram();

            fxs.Drive(); 
            modelS.Drive();
            mx410.Drive();
            idk3000.Drive();
        }
    }
}