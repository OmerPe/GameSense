using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSense.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameSense.Data
{
    public class GameSenseContext : IdentityDbContext<User>
    {
        public GameSenseContext(DbContextOptions<GameSenseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Game> Gamedb { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<GameList> gameUserConnection { get; set; }
        public DbSet<gameArticle> gameArticleConnection { get; set; }
        public DbSet<articleUser> articleUserConnection { get; set; }
    }
}
