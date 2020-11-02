using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            List<string> furniture = new List<string>();
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            while (input != "Purchase")
            {

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    totalPrice += double.Parse(match.Groups["price"].Value) *
                        double.Parse(match.Groups["quantity"].Value);
                }



                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {

                Console.WriteLine(String.Join(Environment.NewLine, furniture));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
