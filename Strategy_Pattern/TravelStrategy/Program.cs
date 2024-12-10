// See https://aka.ms/new-console-template for more information
namespace TravelStrategy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Travel Type : \n1 for Auto \n2 for Bus \n3 for Train \n4 for Taxi");
        int travelType = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You Select Travel type : " + travelType);

        TravelContext travelContext = new();

        if(travelType == (int)TravelType.Bus)
        {
            travelContext.SetTravelStrategy(new BusTravelStrategy());
        }
        else if (travelType == (int)TravelType.Train)
        {
            travelContext.SetTravelStrategy(new TrainTravelStrategy());
        }
        else if (travelType == (int)TravelType.Auto)
        {
            travelContext.SetTravelStrategy(new AutoTravelStrategy());
        }
        else if (travelType == (int)TravelType.Taxi)
        {
            travelContext.SetTravelStrategy(new TaxiTravelStrategy());
        }
        else
        {
            Console.WriteLine("You select an invalid option");
        }

        travelContext.GoToAirport();

        Console.Read();
    }
}
