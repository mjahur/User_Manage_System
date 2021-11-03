using System;
using System.ComponentModel.DataAnnotations;

namespace User_Management_System.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string ProfilePicture { get; set; }
    }
}
