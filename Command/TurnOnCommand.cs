using SmartHomeHub.Devices;

namespace SmartHomeHub.Command;

public class TurnOnCommand : ICommand
{
    private readonly Lamp _lamp;

    public TurnOnCommand(Lamp lamp)
    {
        _lamp = lamp;
    }

    public void Execute()
    {
        _lamp.TurnOn();
    }
}