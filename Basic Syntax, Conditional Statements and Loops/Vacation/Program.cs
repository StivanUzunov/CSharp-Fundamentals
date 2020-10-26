using System;
using System.Collections.Specialized;
using System.Globalization;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfpeople = double.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 22.50;
                }
            }
            double totalPrice = price * numberOfpeople;
            if (typeOfGroup == "Students" && numberOfpeople >= 30)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (typeOfGroup == "Business" && numberOfpeople >= 100)
            {
                totalPrice = totalPrice - 10 * price;
            }
            else if (typeOfGroup == "Regular" && numberOfpeople >= 10 && numberOfpeople <= 20)
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
