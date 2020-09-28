using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int ageRestriction { get; set; }
        [Required]
        public string Developer { get; set; }
        [Required]
        public Coordinates DeveloperLocation { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
