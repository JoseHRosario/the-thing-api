namespace TheThingApi.Services
{
    public interface ILargeLanguageModel
    {
        public string Query(string prompt);
    }
}
