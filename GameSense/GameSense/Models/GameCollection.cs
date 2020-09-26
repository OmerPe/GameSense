using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class GameCollection
    {
        public int GameListID { get; set; }
        public ICollection<Game> Games { get; set; }

    }
}
