using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = String.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!(input[i] == input[i + 1]))
                {
                    result += input[i];
                }

            }
            result += input[input.Length - 1];
            Console.WriteLine(result);
        }
    }
}