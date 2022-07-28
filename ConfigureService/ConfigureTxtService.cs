namespace ConfigureService;

public class ConfigureTxtService : IConfigureService
{
    public string Path;
    public string Configure(string msg)
    {
        var result = File.ReadLines(Path).Select(x => x.Split("="))
            .Select(y => new {Name = y[0], Value = y[1]}).SingleOrDefault(z => z.Name == msg);

        if (result != null)
        {
            return result.Value;
        }
        else
        {
            return null;
        }
    }
}