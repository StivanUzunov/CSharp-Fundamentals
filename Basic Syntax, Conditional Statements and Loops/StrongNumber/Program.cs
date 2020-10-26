using System;
using System.Diagnostics.CodeAnalysis;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temporaryNum = num;
            string strNum = "";
            strNum += num;
            int sum = 0;
            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = temporaryNum % 10;
                temporaryNum = (temporaryNum - currentDigit) / 10;
                int factorial = 1;
                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}