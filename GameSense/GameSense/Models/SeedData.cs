using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using GameSense.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GameSense.Models
{
    public class SeedGames
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameSenseContext(serviceProvider.GetRequiredService<DbContextOptions<GameSenseContext>>()))
            {
                // Look for any Games.
                if (context.Gamedb.Any())
                {
                    return;   // DB has been seeded
                }

                context.Gamedb.AddRange(
                    new Game
                    {
                        Name = "MapleStory",
                        ReleaseDate = DateTime.Parse("2003-4-29"),
                        Genre = "RPG",
                        ageRestriction = 7,
                        Developer = "Wizet",
                        lat = 37.566536,
                        lng = 126.977966,
                        Description = "MapleStory is a free-to-play, 2D, side-scrolling massively multiplayer online role-playing game," +
                        "In the game, players travel the \"Maple World\"," +
                        " defeating monsters and developing their characters' skills and abilities as is typical in role-playing games." +
                        " Players can interact with others in many ways, including chatting and trading." +
                        " Groups of players can band together in parties to hunt monsters and share rewards," +
                        " and can also form guilds to interact more easily with each other.",
                        Path = "https://nxcache.nexon.net/maplestory/landing/images/share_tw.jpg"

                    },

                    new Game
                    {
                        Name = "Call Of Duty : Modern Warfare",
                        ReleaseDate = DateTime.Parse("2019-10-25"),
                        Genre = "FPS",
                        ageRestriction = 18,
                        Developer = "Infinity Ward",
                        lat = 34.166760,
                        lng = -118.604970,
                        Description = "Call of Duty: Modern Warfare is a 2019 first-person shooter video game developed by Infinity Ward and published by Activision.",
                        Path = "https://cdn-products.eneba.com/resized-products/4FTGL0Ta9wnP4dqoBDEEE91a45upnnRDxUHIpKNwvIA_350x200_1x-0.jpeg"

                    },

                    new Game
                    {
                        Name = "Among us",
                        ReleaseDate = DateTime.Parse("2018-06-15"),
                        Genre = "social deduction game",
                        ageRestriction = 7,
                        Developer = "InnerSloth",
                        lat = 47.674911,
                        lng = -122.124001,
                        Description = "Among Us is an online multiplayer social deduction game, " +
                        "developed and published by American game studio InnerSloth and released on June 15, 2018. " +
                        "The game takes place in a space-themed setting where players each take on one of two roles, most being Crewmates, and a predetermined number being Impostors.",
                        Path = "https://images.g2a.com/newlayout/323x433/1x1x0/5122e8fd0384/5f1abb147e696c4b551a16c2"

                    },

                    new Game
                    {
                        Name = "Valorant",
                        ReleaseDate = DateTime.Parse("2020-06-02"),
                        Genre = "FPS",
                        ageRestriction = 16,
                        Developer = "Riot Games",
                        lat = 34.052235,
                        lng = -118.243683,
                        Description = "Valorant is a team-based tactical shooter and first-person shooter set in the near-future.",
                        Path = "https://cdn.vox-cdn.com/thumbor/4lcShxCTWmtzM3lf5Yq5v2IUNdg=/1400x1050/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/19858273/LogoVersion_Beta_Key_Art_VALORANT.jpg"

                    },

                    new Game
                    {
                        Name = "League of Legends",
                        ReleaseDate = DateTime.Parse("2009-10-27"),
                        Genre = "MOBA",
                        ageRestriction = 12,
                        Developer = "Riot Games",
                        lat = 34.052235,
                        lng = -118.243683,
                        Description = "In League of Legends, players assume the role of a \"champion\" with unique abilities, varying around their class, and battle against a team of other player- or computer-controlled champions. In the main game mode, Summoner's Rift, the goal is to destroy the opposing team's Nexus, a structure that lies at the heart of their base, protected by defensive structures.",
                        Path = "https://i1.wp.com/vherald.com/wp-content/uploads/2020/02/league-of-legends-1.jpg?fit=1607%2C895&ssl=1"

                    },

                    new Game
                    {
                        Name = "XCOM : Enemy Unknown",
                        ReleaseDate = DateTime.Parse("2012-10-09"),
                        Genre = "Turn-base Tactical",
                        ageRestriction = 18,
                        Developer = "Firaxis Games",
                        lat = 39.530657,
                        lng = -76.647070,
                        Description = "XCOM: Enemy Unknown casts the player as the commander of an elite military organization. As commander, the player directs their soldiers in turn-based combat missions against alien enemies." +
                        "Between missions, the player directs the organization's research and engineering divisions in creating new technologies and improving XCOM's base of operations, and manages the organization's finances.",
                        Path = "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/XCOM_Enemy_Unknown_Game_Cover.jpg/220px-XCOM_Enemy_Unknown_Game_Cover.jpg"

                    },

                    new Game
                    {
                        Name = "Civilization VI",
                        ReleaseDate = DateTime.Parse("2016-10-21"),
                        Genre = "Turn-base Strategy",
                        ageRestriction = 12,
                        Developer = "Firaxis Games",
                        lat = 39.549130,
                        lng = -76.681330,
                        Description = "Civilization VI is a turn-based strategy video game in which one or more players compete alongside computer-controlled AI opponents to grow their individual civilization from a small tribe to control of the entire planet across several periods of development." +
                        "This can be accomplished by achieving one of several victory conditions, all based on the 4X gameplay elements, \"eXplore,eXpand,eXploit,and eXterminate\"." +
                        "Players found cities, gather nearby resources to build and expand them by adding various city improvements, and build military units to explore and attack opposing forces, while managing the technology development, culture, and government civics for their civilization and their diplomatic relationships with the other opponents.",
                        Path = "https://upload.wikimedia.org/wikipedia/en/3/3b/Civilization_VI_cover_art.jpg"

                    },

                    new Game
                    {
                        Name = "PlayerUnknown's Battlegrounds",
                        ReleaseDate = DateTime.Parse("2017-12-20"),
                        Genre = "Battle Royale",
                        ageRestriction = 16,
                        Developer = "Krafton",
                        lat = 37.377579,
                        lng = 127.113828,
                        Description = "Battlegrounds is a player versus player shooter game in which up to one hundred players fight in a battle royale, a type of large-scale last man standing deathmatch where players fight to remain the last alive. " +
                        "Players can choose to enter the match solo, duo, or with a small team of up to four people. " +
                        "The last person or team alive wins the match.",
                        Path = "https://gamespot1.cbsistatic.com/uploads/scale_medium/1576/15769789/3246445-imagepu.jpg"

                    },

                    new Game
                    {
                        Name = "Need for Speed: Most Wanted",
                        ReleaseDate = DateTime.Parse("2012-10-30"),
                        Genre = "Racing",
                        ageRestriction = 12,
                        Developer = "Criterion Games",
                        lat = 51.236445,
                        lng = -0.569999,
                        Description = "Need for Speed: Most Wanted is set in an open world environment." +
                        " The game takes on the gameplay style of the first Most Wanted title in the Need for Speed franchise." +
                        " Most Wanted allows players to select one car and compete against other racers in three types of events: Sprint races, which involves traveling from one point of the city to another, Circuit races, each having two or three laps total and Speed runs, which involve traversing through a course in the highest average speed possible." +
                        " There are also Ambush races, where the player starts surrounded by cops and must evade their pursuit as quickly as possible.",
                        Path = "https://upload.wikimedia.org/wikipedia/en/b/b0/Nfs-most-wanted-2012-gen-packart.jpg"

                    },

                    new Game
                    {
                        Name = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2013-09-17"),
                        Genre = "Action,Adventure",
                        ageRestriction = 18,
                        Developer = "Rockstar North",
                        lat = 55.952206,
                        lng = -3.192258,
                        Description = "Grand Theft Auto V is an action-adventure game played from either a third-person or first-person perspective." +
                        " Players complete missions—linear scenarios with set objectives—to progress through the story." +
                        " Outside of the missions, players may freely roam the open world. Composed of the San Andreas open countryside area, including the fictional Blaine County, and the fictional city of Los Santos, the world is much larger in area than earlier entries in the series." +
                        " It may be fully explored after the game's beginning without restriction, although story progress unlocks more gameplay content.",
                        Path = "https://images-na.ssl-images-amazon.com/images/I/91O2cwfTxDL._SY445_.jpg"

                    }



                 );
                context.SaveChanges();
            }
        }
    }

    public class SeedUser
    {
        public static async Task Initialize(GameSenseContext context,
                               UserManager<User> userManager,
                               RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";

            string role1 = "Admin";

            string role2 = "User";

            string role3 = "Editor";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role1));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role2));
            }
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role3));
            }

            if (await userManager.FindByNameAsync("Admin@Admin") == null)
            {
                var user = new User
                {
                    UserName = "Admin@Admin",
                    Email = "Admin@Admin",
                    firstName = "Admin",
                    lastName = "Admin",
                    MyUserName = "Admin"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("User@default") == null)
            {
                var user = new User
                {
                    UserName = "User@default",
                    Email = "User@default",
                    firstName = "User",
                    lastName = "User",
                    MyUserName = "User"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            if (await userManager.FindByNameAsync("Editor@default") == null)
            {
                var user = new User
                {
                    UserName = "Editor@default",
                    Email = "Editor@default",
                    firstName = "Editor",
                    lastName = "Editor",
                    MyUserName = "Editor"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role3);
                }
            }
        }
    }
    public class SeedArticle
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameSenseContext(serviceProvider.GetRequiredService<DbContextOptions<GameSenseContext>>()))
            {
                if (context.Article.Any())
                {
                    return; //db already seeded
                }
                context.Article.AddRange(
                    );

                context.SaveChanges();
            }
        }
    }
}
