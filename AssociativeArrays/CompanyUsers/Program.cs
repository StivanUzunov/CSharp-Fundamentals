using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string name = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                if (!companies.ContainsKey(name))
                {
                    companies.Add(name, new List<string>());
                    companies[name].Add(id);
                }
                else
                {
                    List<string> ids = companies[name];
                    if (!ids.Contains(id))
                    {
                        companies[name].Add(id);
                    }
                }

            }
            foreach (var pair in companies)
            {
                Console.WriteLine(pair.Key);
                foreach (var id in pair.Value)
                {
                    Console.WriteLine("-- " + id);
                }
            }



        }
    }
}