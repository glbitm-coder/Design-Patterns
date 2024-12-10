using WithStrategyPattern.Strategy;

namespace WithStrategyPattern;

public class OffRoadVehicle : Vehicle
{
    public OffRoadVehicle() : base(new SportDriveStrategy())
    {

    }
}


