using GameSense.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.DataBase
{
    public class GameDbContext:DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {
        }
        public DbSet<Game> GamesDb { get; set; }
        public DbSet<User> UserDb { get; set; }
    }
}
