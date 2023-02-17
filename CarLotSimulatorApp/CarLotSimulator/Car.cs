using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car 
    {
        public Car() 
        {
            CarLot.numberOfCars++;
        }
        public Car(int year, string make, string model) 
        { 
            Year = year;
            Make = make;
            Model = model;
        }
       
    
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise) 
        {
            Console.WriteLine($"The {Make}'s engine sounds like {noise}");
        }

        public void MakeHonkNoise() 
        {
            Console.WriteLine($"The {Make}'s honk sounds like {HonkNoise}");
        }
    }

}
