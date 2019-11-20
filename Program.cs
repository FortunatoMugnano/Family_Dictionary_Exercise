using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            { { "name", "Immacolata" }, { "age", "35" }
            });
            myFamily.Add("brother", new Dictionary<string, string>()
            { { "name", "Vincenazo" }, { "age", "27" }
            });
            myFamily.Add("mother", new Dictionary<string, string>()
            { { "name", "Giuseppina" }, { "age", "65" }
            });
            myFamily.Add("father", new Dictionary<string, string>()
            { { "name", "Ciro" }, { "age", "61" }
            });
            myFamily.Add("wife", new Dictionary<string, string>()
            { { "name", "Elizabeth" }, { "age", "28" }
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {

                Console.WriteLine($"{member.Value["name"]} is {member.Key} and her age is {member.Value["age"]}");
            }
        }
    }
}