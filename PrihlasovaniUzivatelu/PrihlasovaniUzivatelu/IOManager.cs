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

        public static string filePath = "users.json";


        static public void JsonConverterReg(RegisteredUser user)
        {

            List<RegisteredUser>? users = new();

            
           
            

            //Přidání nového uživatele
            users?.Add(user);

            //Zápis zpět do souboru
           
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, json);



        }

        static public void JsonConverterLog() 
        {

            string json = File.ReadAllText(filePath) ?? string.Empty;
            
            RegisteredUser user = JsonSerializer.Deserialize<RegisteredUser>(json);


        }









        internal static void JsonConverter(RegisteredUser user)
        {
            throw new NotImplementedException();
        }
    }
}
