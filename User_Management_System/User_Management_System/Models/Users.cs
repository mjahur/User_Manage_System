using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_Management_System.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string Email { get; set; }

        [NotMapped]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string HashPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string ProfilePicture { get; set; }
        public string Salt { get; set;  }
    }
}