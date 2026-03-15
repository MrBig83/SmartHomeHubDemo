using SmartHomeHub.Devices;

namespace SmartHomeHub.Command;

public class SetTemperatureCommand : ICommand
{
    private readonly Thermostat _thermostat;
    private readonly int _temp;

    public SetTemperatureCommand(Thermostat thermostat, int temp)
    {
        _thermostat = thermostat;
        _temp = temp;
    }

    public void Execute()
    {
        _thermostat.SetTemperature(_temp);
    }
}