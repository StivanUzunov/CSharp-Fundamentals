using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            var file = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");





        }


    }
}

