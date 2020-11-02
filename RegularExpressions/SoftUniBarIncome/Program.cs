using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            decimal totalPrice = 0;
            string input = Console.ReadLine();
            string pattern = @"^%(?<name>[A-Z]{1}[a-z]+)%[^|$%\.]*?<(?<product>\w+)>[^|$%\.]*?\|(?<quantity>\d+)\|[^|$%\.]*?(?<price>\d+\.?\d*)\$$";
            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value) *
                       decimal.Parse(match.Groups["quantity"].Value);
                    totalPrice += decimal.Parse(match.Groups["price"].Value) *
                            decimal.Parse(match.Groups["quantity"].Value);
                    counter++;

                    if (counter > 0)
                    {
                        Console.WriteLine($"{name}: {product} - {price:f2}");


                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
