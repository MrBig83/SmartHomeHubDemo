using SmartHomeHub.Observer;

namespace SmartHomeHub.Devices;

public interface IDevice
{
    string Name { get; }
    void Attach(IObserver observer);
    void Notify(string message);
}