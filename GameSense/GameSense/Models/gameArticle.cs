using Hammock.Attributes.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class gameArticle
    {
        public int id { get; set; }
        [Required]
        public int gameID { get; set; }
        [Required]
        public int articleID { get; set; }
    }
}
