using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
