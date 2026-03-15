using SmartHomeHub.Devices;
using SmartHomeHub.Observer;
using SmartHomeHub.Command;
using SmartHomeHub.Core;
using SmartHomeHub.Strategy;

namespace SmartHomeHub.Facade;

public class SmartHomeFacade
{
    private readonly List<IDevice> _devices = new();
    private readonly List<IObserver> _observers = new();
    private readonly CommandInvoker _invoker = new();
    private IModeStrategy _mode = new NormalMode();

    public void AddDevice(IDevice device)
    {
        _devices.Add(device);
        foreach (var obs in _observers)
            device.Attach(obs);
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);

        foreach (var d in _devices)
            d.Attach(observer);
    }

    public void SetMode(IModeStrategy mode)
    {
        _mode = mode;
        Console.WriteLine($"Mode switched to {mode.GetType().Name}");
    }

    public void RunCommand(ICommand command)
    {
        _invoker.Execute(command);
    }

    public void ReplayLast(int amount)
    {
        _invoker.Replay(amount);
    }
}