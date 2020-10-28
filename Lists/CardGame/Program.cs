using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var hand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            var hand2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            int sum = 0;
            for (int i = 0; i <= hand.Count - 1; i++)
            {
                if (hand[i] > hand2[i])
                {
                    hand.Add(hand[i]);
                    hand.Add(hand2[i]);
                    hand.Remove(hand[i]);
                    hand2.Remove(hand2[i]);
                    i--;
                }
                else if (hand[i] < hand2[i])
                {
                    hand2.Add(hand2[i]);
                    hand2.Add(hand[i]);
                    hand2.Remove(hand2[i]);
                    hand.Remove(hand[i]);
                    i--;
                }
                else if (hand[i] == hand2[i])
                {
                    hand.Remove(hand[i]);
                    hand2.Remove(hand2[i]);
                    i--;
                }
                if (hand.Count == 0)
                {
                    for (int j = 0; j <= hand2.Count - 1; j++)
                    {
                        sum += hand2[j];
                    }
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                if (hand2.Count == 0)
                {
                    for (int j = 0; j <= hand.Count - 1; j++)
                    {
                        sum += hand[j];
                    }
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}