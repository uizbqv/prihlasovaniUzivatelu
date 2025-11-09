using PrihlasovaniUzivatelu.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrihlasovaniUzivatelu
{
    internal class UserManager
    {
        

        public static void LogIn(string _username, string _password)
        {
            string username = _username;
            string password = _password;
            string hashedPassword = PasswordHasher(_password);

          

        }
        public static void Registration()
        {




        }

        private static DateTime GetRegistrationDate()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }

        private static string PasswordHasher(string _password)//tohle cely neni z my hlavy, NIKDY bych na to neprisel takze se me na to u obhajob neprejte prosim 
        {
            const int saltSize = 32;
            const int keySize = 32;
            const int iterations = 100000;

            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[saltSize];
            rng.GetBytes(salt);
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(_password, salt, iterations, HashAlgorithmName.SHA256);

            byte[] key = new byte[keySize];
            string hash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(key);
            rng.Dispose();
            pbkdf2.Dispose();
            return hash;


        }
    }
}
