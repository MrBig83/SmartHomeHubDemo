namespace SmartHomeHub.Strategy;

public class NormalMode : IModeStrategy
{
    public bool AllowTemperature(int temp) => true;
}