namespace WithStrategyPattern.Strategy;
public class NormalDriveStrategy : IDriveStrategy
{
    public void Drive()
    {
        Console.WriteLine("Normal drive capability");
    }
}


