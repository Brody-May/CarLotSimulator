using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot myCarlot= new CarLot();
            
            var car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Corola";
            car1.Year = 2022;
            car1.IsDriveable= true;
            car1.EngineNoise = "vroooom";
            car1.HonkNoise = "beep";

            myCarlot.ListOfCars.Add(car1);

            var car2 = new Car();
            car2.Make = "Ford";
            car2.Model = "Fusion";
            car2.Year = 2006;
            car2.IsDriveable= true;
            car2.EngineNoise = "vreer";
            car2.HonkNoise = "weep";

            myCarlot.ListOfCars.Add(car2);

            var car3 = new Car();
            car3.Make = "BMW";
            car3.Model = "X1";
            car3.Year = 2021;
            car3.IsDriveable= true;
            car3.EngineNoise = "arrggg";
            car3.HonkNoise = "meep";

            myCarlot.ListOfCars.Add(car3);

            foreach (var car in myCarlot.ListOfCars) 
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise();
                Console.WriteLine();
                Console.WriteLine();
            }
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
