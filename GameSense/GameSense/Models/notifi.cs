using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class notifi
    {
        public int ID { get; set; }
        [Required]
        public string Headline { get; set; }
        [Required]
        public string body { get; set; }
        [Required]
        public bool read { get; set; } = false;
        [Required]
        [Column(TypeName = "nvarchar(460)")]
        public string userID { get; set; }
    }
}
