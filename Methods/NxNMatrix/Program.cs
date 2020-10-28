using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void Matrix(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colums = 1; colums <= n; colums++)
                {
                    Console.Write(n + " ");

                }
                Console.WriteLine();
            }
        }


    }
}

