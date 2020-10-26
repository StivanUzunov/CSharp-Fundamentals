using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + j);
                        char third = (char)('a' + k);

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
