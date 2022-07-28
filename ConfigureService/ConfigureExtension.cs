using Microsoft.Extensions.DependencyInjection;

namespace ConfigureService;

public static class ConfigureExtension
{
    public static void AddSxr(this IServiceCollection service, string path)
    {
        service.AddScoped(typeof(IConfigureService), s=>new ConfigureTxtService(){Path = path});
    }
}