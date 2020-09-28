using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class GameList
    {
        public int ID { get; set; }
        public int userId { get; set; }
        public User usr { get; set; }

        public int gameId { get; set; }
        public Game game { get; set; }
    }
}
