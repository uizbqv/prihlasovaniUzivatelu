using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static PrihlasovaniUzivatelu.IOManager;

namespace PrihlasovaniUzivatelu
{
    internal class IOManager
    {

        private static readonly string filePath = "users.json";


        static public void JsonConverterReg(User user)
        {

            List<User>? users = new();

            //pokud json soubor existuje, načteme ho (ochrana proti spadnutí)
           
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                    users = JsonSerializer.Deserialize<List<User>>(existingJson);
            }

            //Přidání nového uživatele
            users?.Add(user);

            //Zápis zpět do souboru
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filePath, json);



        }

        static public void JsonConverterLog(User user) 
        {

            string json = JsonSerializer.Deserialize<List<User>>();


        }









        internal static void JsonConverter(Properties.User user)
        {
            throw new NotImplementedException();
        }
    }
}
