using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class GameSearchModel
    { 
        public List<Game> Games { get; set; }
        public string Developer { get; set; }
        public SelectList Developers { get; set; }
        public string Genre { get; set; }
        public SelectList Genres { get; set; }
        public string GameName { get; set; }
        [DataType(DataType.Time)]
        public DateTime ReleaseDate { get; set; }
        public string SearchString { get; set; }
    }
}
