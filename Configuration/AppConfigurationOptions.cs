namespace TheThingApi.Configuration
{
    public class AppConfigurationOptions
    {
        public const string AppConfiguration = "AppConfiguration";

        public List<string> AllowedLogins { get; set; } = new ();
        public string OAuthAudience { get; set; } = String.Empty;
    }
}
