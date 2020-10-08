using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class Article
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public Game game { get; set; }
        public string Path { get; set; }
        public string Content { get; set; }
        public string BriefContent { get; set; }
        public int Likes { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }

}
