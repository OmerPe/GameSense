using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class MyList
    {
        public int MyListID { get; set; }
        public ICollection<Game> MyGames { get; set; }
    }
}
