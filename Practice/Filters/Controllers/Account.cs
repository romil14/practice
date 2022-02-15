using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UnAuthorize()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
