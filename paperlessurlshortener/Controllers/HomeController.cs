using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using paperlessurlshortener.Models;

namespace paperlessurlshortener.Controllers
{
    public class URLResponse
    {
        public string url { get; set; }
        public string status { get; set; }
        public string token { get; set; }
    }
    public class HomeController : Controller
    {
        [HttpGet, Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("/")]
        public IActionResult PostURL([FromBody] string url)
        {
            throw new NotImplementedException();
        }

        [HttpGet, Route("/{token}")]
        public IActionResult NixRedirect([FromRoute] string token)
        {
            throw new NotImplementedException();
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
