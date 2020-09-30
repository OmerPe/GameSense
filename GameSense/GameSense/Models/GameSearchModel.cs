using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class GameSearchModel
    {
        public int ID { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public string GameName { get; set; }
        [DataType(DataType.Time)]
        public DateTime ReleaseDate { get; set; }
    }
}
