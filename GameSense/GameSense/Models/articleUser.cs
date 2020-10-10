﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class articleUser
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(460)")]
        public string userID { get; set; }
        [Required]
        public int articleID { get; set; }
    }
}
