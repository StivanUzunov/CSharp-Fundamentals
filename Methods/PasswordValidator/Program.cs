using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            IsValidatePassword(password);
        }

        static void IsValidatePassword(string text)
        {
            bool invalid = false;
            if (text.Length < 6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (CheckIfContainsOnlyDigitsAndLetters(text) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (CountNumberOfDigits(text) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckIfContainsOnlyDigitsAndLetters(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char currentchar = text[i];
                if (!((currentchar >= 48 && currentchar <= 57)
                    || (currentchar >= 65 && currentchar <= 90)
                    || (currentchar >= 97 && currentchar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }
        static int CountNumberOfDigits(string text)
        {
            int digitsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }





    }
}
