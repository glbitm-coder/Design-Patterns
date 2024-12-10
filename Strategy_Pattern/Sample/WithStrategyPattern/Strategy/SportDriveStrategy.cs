namespace WithStrategyPattern.Strategy;
public class SportDriveStrategy : IDriveStrategy
{
    public void Drive()
    {
        Console.WriteLine("Sport drive capability");
    }
}


