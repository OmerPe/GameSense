using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameSense.Data;
using GameSense.Models;
using Microsoft.AspNetCore.Http;

namespace GameSense.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameContext _context;

        public GamesController(GameContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index(string Genre,string Developer, string searchString)
        {
            IQueryable<string> genreQuery = from G in _context.Gamedb
                                            orderby G.Genre
                                            select G.Genre;
            IQueryable<string> devQuery = from D in _context.Gamedb
                                            orderby D.Developer
                                            select D.Developer;

            var games = from G in _context.Gamedb
                         select G;
 
            if (!string.IsNullOrEmpty(searchString))
            {
                games = games.Where(s => s.Name.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(Genre))
            {
                games = games.Where(g => g.Genre == Genre);
            }
            if (!string.IsNullOrEmpty(Developer))
            {
                games = games.Where(d => d.Developer == Developer);
            }

            var GameSearch = new GameSearchModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Developers = new SelectList(await devQuery.Distinct().ToListAsync()),
                Games = await games.ToListAsync()
            };

            return View(GameSearch);
        }
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Gamedb
                .FirstOrDefaultAsync(m => m.ID == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,ReleaseDate,Genre,ageRestriction,Developer,Description")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Gamedb.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }
      

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,ReleaseDate,Genre,ageRestriction,Developer")] Game game)
        {
            if (id != game.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Gamedb
                .FirstOrDefaultAsync(m => m.ID == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Gamedb.FindAsync(id);
            _context.Gamedb.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Gamedb.Any(e => e.ID == id);
        }
        public IActionResult SearchGame(string GameName, string Genre, string Developer)
        {
            ViewBag.usr = HttpContext.Session.GetInt32("usr");
            if (HttpContext.Session.GetString("Type") == null)
            {
                ViewBag.message = "Log in";
            }
            else
            {
                ViewBag.message2 = "Hi " + HttpContext.Session.GetString("userName").ToString();
            }
            return View();
        }
    }
   
}
