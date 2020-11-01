using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < commandsCount; i++)
            {
                List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (command[0] == "register")
                {
                    string username = command[1];
                    string licensePlate = command[2];

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                    }

                    else
                    {
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                        users.Add(username, licensePlate);
                    }
                }

                else if (command[0] == "unregister")
                {
                    string username = command[1];

                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            Print(users);
        }

        static void Print(Dictionary<string, string> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
