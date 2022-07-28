// See https://aka.ms/new-console-template for more information

using ConfigureService;
using LoggerService;
using MailService;
using Microsoft.Extensions.DependencyInjection;


ServiceCollection service = new ServiceCollection();
//service.AddScoped<IConfigureService,ConfigureService.ConfigureService>();
//service.AddScoped(typeof(IConfigureService), c => new ConfigureTxtService {Path = @"/Users/shenxinran/Desktop/Text.txt"});
service.AddSxr(@"/Users/shenxinran/Desktop/Text.txt");
service.AddScoped<IMailService, MailService.MailService>();
service.AddScoped<ILoggerService, LoggerService.LoggerService>();
using (var sp = service.BuildServiceProvider())
{
    var mail = sp.GetRequiredService<IMailService>();
    mail.SendMail();
}


