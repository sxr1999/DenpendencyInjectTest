namespace LoggerService;

public interface ILoggerService
{
    public void LogInfo(string msg);

    public void LogError(string msg);
}