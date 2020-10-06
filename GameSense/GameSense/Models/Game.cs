using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameSense.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Age Restriction")]
        public int ageRestriction { get; set; }
        [Required]
        public string Developer { get; set; }
        public String DeveloperLocation { get; set; }
        [Required]
        public string Description { get; set; }
        public string Path { get; set; }
        public int Views { get; set; }
    }
}
