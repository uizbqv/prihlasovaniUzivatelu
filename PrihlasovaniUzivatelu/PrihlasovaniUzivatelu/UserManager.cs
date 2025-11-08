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
            



        }
        public static void Registration() 
        {
            


        
        }

        private static DateTime GetRegistrationDate() 
        {
            DateTime currentDate = DateTime.Now;
            return currentDate; 
        }

        private static string PasswordHasher() 
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
        
        }


    }
}
