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

            var cars = new CarLot();
            
            // Object Initializer Sntax:
            Car FirstCar = new Car()
            {
                Make = "BMW",
                Model = "M4",
                Year = 2021,
                EngineNoise = "loud",
                HonkNoise = "loud",
                IsDriveable = true,
            };
            FirstCar.MakeEngineNoise(FirstCar.EngineNoise);
            FirstCar.MakeHonkNoise(FirstCar.HonkNoise);
            
            cars.Cars.Add(FirstCar);
            Console.WriteLine($"Number of cars on lot: {CarLot._numberofCars}");
            
            // Dot Notation:
            Car SecondCar = new Car();
            SecondCar.Make = "Audi";
            SecondCar.Model = "A3";
            SecondCar.Year = 2018;
            SecondCar.EngineNoise = "medium";
            SecondCar.HonkNoise = "low";
            SecondCar.IsDriveable = true;
            
            SecondCar.MakeEngineNoise(SecondCar.EngineNoise);
            SecondCar.MakeHonkNoise(SecondCar.HonkNoise);
            
            cars.Cars.Add(SecondCar);
           
            Console.WriteLine($"Number of cars on lot: {CarLot._numberofCars}");
            
            // Custom Constructor:
            var ThirdCar = new Car("For", "Mustang", 1969, "loud", "low", false);
            ThirdCar.MakeEngineNoise(ThirdCar.EngineNoise);
            ThirdCar.MakeHonkNoise(ThirdCar.HonkNoise);
            
            cars.Cars.Add(ThirdCar);
          
            Console.WriteLine($"Number of cars on lot: {CarLot._numberofCars}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            cars.Inventory();
            
            


        }
    }
}
