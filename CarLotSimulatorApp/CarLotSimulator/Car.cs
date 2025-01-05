using System;
using System.Dynamic;

namespace CarLotSimulator;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine($"The engine noise is {engineNoise}");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine($"The honk noise is {honkNoise}");
    }


    public Car()
    {
        CarLot._numberofCars++;
    }
    
    public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
    {
        Make = make;
        Model = model;
        Year = year;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;
        CarLot._numberofCars++;
    }

}
