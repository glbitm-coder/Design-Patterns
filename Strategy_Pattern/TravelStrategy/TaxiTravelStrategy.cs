using System;

namespace TravelStrategy
{
    public class TaxiTravelStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 1000");
        }
    }
}