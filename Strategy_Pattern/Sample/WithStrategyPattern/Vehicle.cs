using WithStrategyPattern.Strategy;

namespace WithStrategyPattern;
public class Vehicle(IDriveStrategy driveObject)
{
    public IDriveStrategy? _driveObject = driveObject;

    public void Drive()
    {
        _driveObject.Drive();
    }
}