namespace TheThingApi.Services
{
    public class ChatGPT : ILargeLanguageModel
    {
        public string Query(string prompt)
        {
            return "ChatGPT3.5";
        }
    }
}
