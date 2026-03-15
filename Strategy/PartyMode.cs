namespace SmartHomeHub.Strategy;

public class PartyMode : IModeStrategy
{
    public bool AllowTemperature(int temp) => true;
}