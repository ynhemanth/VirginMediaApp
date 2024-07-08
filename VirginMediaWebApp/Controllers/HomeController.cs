using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.Abstraction;
using System.Diagnostics;
using VirginMediaWebApp.Models;

namespace VirginMediaWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalogueService _catalogueService;
        

        public HomeController(ILogger<HomeController> logger, ICatalogueService catalogueService)
        {
            _logger = logger;
            _catalogueService = catalogueService;        
        }

        public async Task<IActionResult> Index()
        {
            var data = await _catalogueService.GetAll();
            _logger.Log(LogLevel.Information, "Called catalogue items", DateTime.Now);
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
