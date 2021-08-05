using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Joeffry" }, { "age", "30" } });
            myFamily.Add("uncle", new Dictionary<string, string>() { { "name", "Paulo" }, { "age", "55" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Roxie" }, { "age", "57" } });

            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");   
            }
        }
    }
}
