using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SumOfFirstTwoNumbers(num1, num2);
            SubtractOfNumbers(SumOfFirstTwoNumbers(num1, num2), num3);


        }
        static int SumOfFirstTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static double SubtractOfNumbers(int sum, int num3)
        {
            double result = sum - num3;

            Console.WriteLine(result);
            return result;
        }

    }
}