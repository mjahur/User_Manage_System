using System;
using BCrypt;
namespace User_Management_System.Security
{
    public static class PasswordHash
    {
        public static string GenerateHash(string salt, string password)
        {
           string hashedpassword = BCrypt.Net.BCrypt.HashPassword(password+salt);
           return hashedpassword;
        }
    }
}