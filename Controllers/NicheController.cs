using Microsoft.AspNetCore.Mvc;
using TheThingApi.Services;

namespace TheThingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NicheController : ControllerBase
    {
        private readonly ILogger<NicheController> _logger;
        private readonly ILargeLanguageModel _llm;

        public NicheController(ILogger<NicheController> logger, ILargeLanguageModel llm)
        {
            _logger = logger;
            _llm = llm;
        }

        [HttpGet]
        public string Get()
        {
            return _llm.Query("niche");
        }
    }
}
