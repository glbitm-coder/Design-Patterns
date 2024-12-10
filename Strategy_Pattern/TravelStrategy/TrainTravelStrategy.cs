using System;

namespace TravelStrategy
{
    public class TrainTravelStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Train and will be charged Rs 200");
        }
    }
}