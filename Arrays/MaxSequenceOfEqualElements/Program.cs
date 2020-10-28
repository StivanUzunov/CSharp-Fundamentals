using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxLength = 0;
        int length = 1;

        int start = 0;
        int bestStart = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                length++;
            }
            else
            {
                length = 1;
                start = i + 1;
            }

            if (length > maxLength)
            {
                maxLength = length;
                bestStart = start;
            }
        }

        for (int i = bestStart; i < bestStart + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

}