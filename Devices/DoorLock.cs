using SmartHomeHub.Observer;

namespace SmartHomeHub.Devices;

public class DoorLock : IDevice
{
    private readonly List<IObserver> _observers = new();
    public string Name { get; }

    public DoorLock(string name)
    {
        Name = name;
    }

    public void Lock()
    {
        Notify($"{Name} locked");
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