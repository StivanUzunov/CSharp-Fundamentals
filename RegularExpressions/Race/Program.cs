using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> namesAndKM = new Dictionary<string, int>();
            string[] contestants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                string namePattern = "[A-Za-z]";
                string digitsPattern = @"\d";

                var nameMatch = Regex.Matches(input, namePattern);
                var kmMathes = Regex.Matches(input, digitsPattern);
                var sumOfKm = kmMathes.Select(x => int.Parse(x.Value)).Sum();
                var name = String.Concat(nameMatch);


                if (contestants.Contains(name))
                {
                    if (namesAndKM.ContainsKey(name))
                    {
                        namesAndKM[name] += sumOfKm;
                    }
                    else
                    {
                        namesAndKM.Add(name, sumOfKm);
                    }
                }




                input = Console.ReadLine();
            }


            var sorted = namesAndKM.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);

        }
    }
}
