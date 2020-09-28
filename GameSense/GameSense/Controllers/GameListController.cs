using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GameSense.Controllers
{
    public class GameListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
