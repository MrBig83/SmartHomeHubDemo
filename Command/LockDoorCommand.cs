using SmartHomeHub.Devices;

namespace SmartHomeHub.Command;

public class LockDoorCommand : ICommand
{
    private readonly DoorLock _door;

    public LockDoorCommand(DoorLock door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Lock();
    }
}