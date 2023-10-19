﻿using System;
using System.Collections.Generic;

// Клас Дорога
class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int NumberOfLanes { get; set; }
    public int TrafficLevel { get; set; }

    public Road(double length, double width, int numberOfLanes)
    {
        Length = length;
        Width = width;
        NumberOfLanes = numberOfLanes;
        TrafficLevel = 0;
    }
}

// Клас Транспортний засіб
class Vehicle : IDriveable
{
    public string Type { get; set; }
    public double Speed { get; set; }
    public double Size { get; set; }

    public Vehicle(string type, double speed, double size)
    {
        Type = type;
        Speed = speed;
        Size = size;
    }

    public void Move()
    {
        Console.WriteLine($"The {Type} is moving at a speed of {Speed} km/h.");
    }

    public void Stop()
    {
        Console.WriteLine($"The {Type} has stopped.");
    }
}

// Інтерфейс для транспортного засобу
interface IDriveable
{
    void Move();
    void Stop();
}

// (А) Клас для імітації руху та змін руху транспортних засобів на дорозі
class TrafficSimulation
{
    public static void SimulateTraffic(Road road, List<Vehicle> vehicles)
    {
        Console.WriteLine($"Simulating traffic on a {road.Length} km road with {road.NumberOfLanes} lanes.");

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }

        // Оцінка рівня трафіку на дорозі і визначення необхідних дій для оптимізації
        if (road.TrafficLevel < 5)
        {
            Console.WriteLine("Traffic is flowing smoothly.");
        }
        else if (road.TrafficLevel < 8)
        {
            Console.WriteLine("Traffic is moderate. Consider traffic management.");
        }
        else
        {
            Console.WriteLine("Traffic is congested. Implement traffic optimization.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Road cityRoad = new Road(10.5, 3.5, 2);

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Car", 60.0, 4.0),
            new Vehicle("Bus", 40.0, 12.0),
            new Vehicle("Truck", 50.0, 18.0)
        };

        TrafficSimulation.SimulateTraffic(cityRoad, vehicles);
    }
}
