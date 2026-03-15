namespace SmartHomeHub.Core;

public class Logger
{
    private static Logger _instance;

    public static Logger Instance => _instance ??= new Logger();

    private Logger(){}

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}