using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameSense.Data;
using GameSense.Models;
using Microsoft.AspNetCore.Authorization;
using TweetSharp;

namespace GameSense.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly GameSenseContext _context;

        public ArticlesController(GameSenseContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> UpdateLikes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article.FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View("Details", article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<int> UpdateLikes(int id, string userid)
        {
            if (!isLiked(id, userid))
            {
                Article update = _context.Article.ToList().Find(a => a.ID == id);
                update.Likes += 1;

                articleUser tmp = new articleUser {
                    articleID = id,
                    userID = userid
                };

                _context.articleUserConnection.Update(tmp);
                await _context.SaveChangesAsync();

                return update.Likes;
            }
            Article article = _context.Article.ToList().Find(a => a.ID == id);
            return article.Likes;
        }

        public int Addlike(int? id)
        {
            Article update = _context.Article.ToList().Find(a => a.ID == id);

            update.Likes += 1;
            _context.SaveChanges();

            return update.Likes;
        }

        [Authorize(Roles = "Admin,Editor")]
        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var gameSenseContext = _context.Article.Include(a => a.game);
            return View(await gameSenseContext.ToListAsync());
        }
        [AllowAnonymous]
        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .Include(a => a.game)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }
        [Authorize(Roles = "Admin,Editor")]
        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["GameID"] = new SelectList(_context.Gamedb, "ID", "Name");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin,Editor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,GameID,Path,Content,Likes")] Article article)
        {
            if (ModelState.IsValid)
            {
                string key = "QNm1VD6rhVk5uQO1lFE4xj3TK";
                string secret = "wyrMxltWxebxRh0CpWpetfstsZvKCvtleQbM0ybuLkJ9pmIKlS";
                string token = "392392197-2Tche78I2E0ambYnzoNTHlC58ohagMciJQ31uf33";
                string tokenSecret = "ODMVW5HsJho3te2XcSHdINGL3q0zPHR70PllOoOWUxq6O";

                var service = new TweetSharp.TwitterService(key, secret);
                service.AuthenticateWith(token, tokenSecret);

                var result = service.SendTweet(new SendTweetOptions
                {
                    Status = "Hey! Game Sense got a new Article for you gamers!\n come check it out!!"
                });


                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameID"] = new SelectList(_context.Gamedb, "ID", "Name", article.GameID);
            return View(article);
        }

        [Authorize(Roles = "Admin,Editor")]
        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["GameID"] = new SelectList(_context.Gamedb, "ID", "Name", article.GameID);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin,Editor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,GameID,Path,Title,Content,BriefContent,Likes")] Article article)
        {
            if (id != article.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ID))
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
            ViewData["GameID"] = new SelectList(_context.Gamedb, "ID", "Name", article.GameID);
            return View(article);
        }
        [Authorize(Roles = "Admin,Editor")]
        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .Include(a => a.game)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        [Authorize(Roles = "Admin,Editor")]
        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Article.FindAsync(id);
            _context.Article.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Article.Any(e => e.ID == id);
        }

        public bool isLiked(int id,string userid)
        {
            return _context.articleUserConnection.Any(e => e.articleID == id && e.userID == userid);
        }
    }
}
