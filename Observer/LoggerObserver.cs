using SmartHomeHub.Core;

namespace SmartHomeHub.Observer;

public class LoggerObserver : IObserver
{
    public void Update(string message)
    {
        Logger.Instance.Log(message);
    }
}