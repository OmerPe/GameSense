using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }

    }
}
