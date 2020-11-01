using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {

                char symbol = text[i];
                if (symbol == ' ')
                {
                    continue;
                }
                if (charsCount.ContainsKey(symbol))
                {
                    charsCount[symbol]++;
                }
                else
                {
                    charsCount.Add(symbol, 1);
                }
            }
            foreach (var pair in charsCount)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}