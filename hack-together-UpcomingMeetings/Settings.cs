using Microsoft.Extensions.Configuration;

public class Settings
{
    public string? ClientId { get; set; }    

    public static Settings LoadSettings()
    {        
        IConfiguration config = new ConfigurationBuilder()            
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        return config.GetRequiredSection("Settings").Get<Settings>() ??
            throw new Exception("Could not load app settings.");
    }
}