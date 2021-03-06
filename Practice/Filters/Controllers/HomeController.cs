using Filters.Custome.Filters;
using Filters.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    //Controller Level
    //[CustomAuthorizationFilter(Role = "Admin")]
    //[CustomResourceFilter]
    //[CustomActionFilter]
    //[CustomResultFilter]

    //[CustomExceptionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    
        public IActionResult Index()
        {
            //HttpContext.Response.WriteAsync("Action Execuation => ");

            //throw new ArgumentNullException();
            return View();
        }
        // Action Level
        //[CustomAuthorizationFilter]
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
