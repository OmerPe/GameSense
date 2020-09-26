using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSense.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string salt { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]
        public string eMail { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        public ICollection<MyList> MyGameList { get; set; }
    }
}
