using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class Coordinates
    {
        public int ID { get; set; }
        public int gameId { get; set; }
        public double latitude { get; set; }
        public double longtitude { get; set; }

    }
}
