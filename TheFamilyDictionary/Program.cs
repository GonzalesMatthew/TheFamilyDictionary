using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Joeffry" }, { "age", "30" } });
            myFamily.Add("uncle", new Dictionary<string, string>() { { "name", "Paulo" }, { "age", "55" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Roxie" }, { "age", "57" } });

            foreach(KeyValuePair<string> entry in myFamily)
            {

            }
        }
    }
}
