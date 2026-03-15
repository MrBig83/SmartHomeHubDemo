namespace SmartHomeHub.Strategy;

public interface IModeStrategy
{
    bool AllowTemperature(int temp);
}