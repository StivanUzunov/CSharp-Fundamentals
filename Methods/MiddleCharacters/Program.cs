using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MiddleChar(text);
        }

        static void MiddleChar(string text)

        {
            char[] characters = text.ToCharArray();

            if (text.Length % 2 != 0)
            {
                Console.WriteLine(characters[text.Length / 2]);
            }
            else
            {
                Console.Write(characters[text.Length / 2 - 1]);
                Console.WriteLine(characters[text.Length / 2]);
            }
        }


    }
}