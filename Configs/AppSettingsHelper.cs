using Microsoft.Extensions.Configuration;

namespace SOAT.Labs.Configs
{
    public class AppSettingsHelper
    {
        public StorageOptions StorageOptions { get; set; }

        public static AppSettingsHelper LoadAppSettings()
        {
            IConfigurationRoot configRoot = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            AppSettingsHelper appSettings = configRoot.Get<AppSettingsHelper>();
            return appSettings;
        }
    }
}