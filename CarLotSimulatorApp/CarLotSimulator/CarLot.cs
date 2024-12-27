using System;

namespace CarLotSimulator;
using System.Collections.Generic;

public class CarLot
{
    public List<Car> Cars { get; set; } = new List<Car>();

    public void Inventory()
    {
        foreach (var car in Cars)
        {
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
        }
    }
}