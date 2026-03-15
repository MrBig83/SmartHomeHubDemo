namespace SmartHomeHub.Strategy;

public class EcoMode : IModeStrategy
{
    public bool AllowTemperature(int temp) => temp <= 24;
}