using SmartHomeHub.Observer;

namespace SmartHomeHub.Devices;

public class Lamp : IDevice
{
    private readonly List<IObserver> _observers = new();
    public string Name { get; }

    public Lamp(string name)
    {
        Name = name;
    }

    public void TurnOn()
    {
        Notify($"{Name} turned ON");
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