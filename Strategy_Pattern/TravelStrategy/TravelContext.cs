using System;

namespace TravelStrategy
{
    public class TravelContext
    {
        private ITravelStrategy? _strategy;

        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            _strategy = strategy;
        }

        public void GoToAirport()
        {
            _strategy.GoToAirport();
        }
    }
}