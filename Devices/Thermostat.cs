using SmartHomeHub.Observer;

namespace SmartHomeHub.Devices;

public class Thermostat : IDevice
{
    private readonly List<IObserver> _observers = new();
    public string Name { get; }

    public Thermostat(string name)
    {
        Name = name;
    }

    public void SetTemperature(int temp)
    {
        Notify($"{Name} temperature set to {temp}°C");
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Notify(string message)
    {
        foreach (var o in _observers)
            o.Update(message);
    }
}