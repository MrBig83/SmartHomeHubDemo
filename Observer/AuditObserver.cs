namespace SmartHomeHub.Observer;

public class AuditObserver : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"[AUDIT] {DateTime.Now}: {message}");
    }
}