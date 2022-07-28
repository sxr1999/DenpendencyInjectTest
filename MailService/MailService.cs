using ConfigureService;
using LoggerService;

namespace MailService;

public class MailService : IMailService
{
    private readonly ILoggerService _loggerService;
    private readonly IConfigureService _configureService;

    public MailService(ILoggerService loggerService,IConfigureService configureService)
    {
        _loggerService = loggerService;
        _configureService = configureService;
    }
    
    public void SendMail()
    {
        _loggerService.LogInfo("准备发送邮件");
        var name = _configureService.Configure("Name");
        var age = _configureService.Configure("Age");
        var Gender = _configureService.Configure("Gender");
        Console.WriteLine($"用户名:{name},年龄{age},性别{Gender}");
        Console.WriteLine("开始发送邮件");
        _loggerService.LogInfo("邮件发送完成");
    }
}