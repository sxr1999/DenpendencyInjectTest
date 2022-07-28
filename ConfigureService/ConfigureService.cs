namespace ConfigureService;

public class ConfigureService : IConfigureService
{
    public string Configure(string msg)
    {
        Console.WriteLine($"配置服务已经启动，内容为{msg}");
        return $"配置服务已经启动，内容为{msg}";
    }
}