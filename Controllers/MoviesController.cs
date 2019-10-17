using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vidily.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movie = new MoviesController();
            return View();
        }
    }
}