using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = String.Empty;
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                encrypted += (char)(text[i] + 3);
            }
            Console.WriteLine(encrypted);




        }


    }
}