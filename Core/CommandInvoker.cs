using SmartHomeHub.Command;

namespace SmartHomeHub.Core;

public class CommandInvoker
{
    private readonly List<ICommand> _history = new();

    public void Execute(ICommand command)
    {
        command.Execute();
        _history.Add(command);
    }

    public void Replay(int last)
    {
        foreach (var cmd in _history.TakeLast(last))
        {
            cmd.Execute();
        }
    }
}