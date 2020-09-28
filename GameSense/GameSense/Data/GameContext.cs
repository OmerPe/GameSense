﻿using Microsoft.EntityFrameworkCore;
using GameSense.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options): base(options)
        {
        }

        public DbSet<Game> Gamedb { get; set; }
        public DbSet<User> Usrdb { get; set; }
    }
}
