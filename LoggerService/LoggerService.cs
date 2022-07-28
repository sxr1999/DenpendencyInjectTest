namespace LoggerService;

public class LoggerService : ILoggerService
{
    public void LogInfo(string msg)
    {
        Console.WriteLine($"日志已经被启用,内容为: {msg}");
    }

    public void LogError(string msg)
    {
        Console.WriteLine($"错误消息为: {msg}");
    }
}