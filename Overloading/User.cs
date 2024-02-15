using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class User
    {
        public string Name { get; set; }
        public string HashPassword { get; set; }
        public DateTime RegistrationData { get; set; }

        public User(string name, string pass)
        {
            Name = name;
            HashPassword = GetHash(pass);
            RegistrationData = DateTime.Now; 
        }
        public string GetHash(string pass)
        {
            byte[] passBytes = Encoding.Default.GetBytes(pass); 
            byte[] hashBytes = SHA512.HashData(passBytes);

            return BitConverter.ToString(hashBytes);
        }

        public static bool operator ==(User left, User right)
        {
            return left.HashPassword == right.HashPassword;   
        }

        public static bool operator !=(User left, User right)
        {
            return left.HashPassword != right.HashPassword;
        }
    }
}
