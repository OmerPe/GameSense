using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GameSense.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [PersonalData]
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string MyUserName { get; set; }
        [PersonalData]
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string firstName { get; set; }
        [PersonalData]
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string lastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Born in")]
        public DateTime DateOfBirth { get; set; }
    }
}
