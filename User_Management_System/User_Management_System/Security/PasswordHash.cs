using System;
using BCrypt;
namespace User_Management_System.Security
{
    public class PasswordHash
    {
        public string GenerateHash(string salt, string password)
        {
           string hashedpassword = BCrypt.Net.BCrypt.HashPassword(password+salt);
           return hashedpassword;
        }
    }
}