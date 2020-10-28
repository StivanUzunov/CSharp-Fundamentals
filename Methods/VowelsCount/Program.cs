using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            CountVowels(text);
        }
        static void CountVowels(string text)
        {
            int vowelsCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        vowelsCounter++;
                        break;
                    case 'e':
                        vowelsCounter++;
                        break;
                    case 'i':
                        vowelsCounter++;
                        break;
                    case 'o':
                        vowelsCounter++;
                        break;
                    case 'u':
                        vowelsCounter++;
                        break;
                }
            }
            Console.WriteLine(vowelsCounter);


        }
    }
}