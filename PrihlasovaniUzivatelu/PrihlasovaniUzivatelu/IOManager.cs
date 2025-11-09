using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace PrihlasovaniUzivatelu
{
    internal class IOManager
    {
        static void JsonConverter() 
        { 
        
        UserManager u = new UserManager();

        
        string mujJson = JsonSerializer.Serialize(u);
        Console.WriteLine(mujJson);
        
            



        }

    }
}
