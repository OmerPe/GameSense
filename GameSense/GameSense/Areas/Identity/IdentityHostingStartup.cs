using System;
using GameSense.Data;
using GameSense.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GameSense.Areas.Identity.IdentityHostingStartup))]
namespace GameSense.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GameSenseContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GameSenseContext")));
  
            });
        }
    }
}