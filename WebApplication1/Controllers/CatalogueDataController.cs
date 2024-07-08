using Microsoft.AspNetCore.Mvc;
using Service.Abstraction;
using Service.Model;

namespace VirginMediaApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogueDataController : ControllerBase
    {        
        private readonly ILogger<CatalogueDataController> _logger;        
        private readonly ICatalogueService  _catalogueService;

        public CatalogueDataController(ILogger<CatalogueDataController> logger, ICatalogueService catalogueService)
        {
            _logger = logger;
            _catalogueService = catalogueService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<CatalogueDataCore>> Get()
        {
            var data =  await _catalogueService.GetAll();

            _logger.Log(LogLevel.Information, "Called catalogue items", DateTime.Now);

            return data;            
        }
    }
}
