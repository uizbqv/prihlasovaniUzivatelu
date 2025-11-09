using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrihlasovaniUzivatelu
{
    internal class IOManager
    {
        static public void JsonConverter() 
        {
            UserManager um = new UserManager();
            
            User u = new User()

            string Json = JsonSerializer.Serialize(u);
            Console.WriteLine(Json);

        }


    }

    internal class User
    {
        public string username { get; }
        public string password { get; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

    }
}
