using System;
using System.Security.Cryptography;

namespace User_Management_System.Security
{
    public static class PasswordSalt
    {
        public static string GenerateSalt(int length)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[length];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
    }
}
