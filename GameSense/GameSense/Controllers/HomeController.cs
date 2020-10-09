using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GameSense.Models;
using GameSense.Data;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Web;
using TweetSharp;

namespace GameSense.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GameSenseContext _context;
        public HomeController(ILogger<HomeController> logger,GameSenseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var articles = (from art in _context.Article
                            orderby art.Date descending
                            select art).Take(6);
            //var gameContext = _context.Article.Include(a => a.game);
            return View(await articles.ToListAsync());
        }
        /*public async Task<IActionResult> Index(string usr)
        {
            var articles = (from art in _context.Article
                            orderby art.Likes descending
                            select art).Take(6);
            //var gameContext = _context.Article.Include(a => a.game);
            return View(await articles.ToListAsync());
        }
        */

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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
