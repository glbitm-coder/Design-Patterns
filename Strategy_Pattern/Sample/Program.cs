// See https://aka.ms/new-console-template for more information
using WithStrategyPattern;

namespace Sample;

public static class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello");
        Vehicle vehicle = new OffRoadVehicle();
        vehicle.Drive();
        Console.ReadLine();
    }
}

