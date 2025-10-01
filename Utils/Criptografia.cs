using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt)
<<<<<<< HEAD
        {
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {   
        salt = hmac.Key;
        hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
        }
=======
{
	using (var hmac = new System.Security.Cryptography.HMACSHA512())
	{
		salt = hmac.Key;
		hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
	}
}
>>>>>>> 162d5722479230e1effdebfa2dd54f8a27124703
    }
}