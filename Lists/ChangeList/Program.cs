using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] elements = command.Split();

                if (elements[0] == "Delete")
                {
                    int elementToDelete = int.Parse(elements[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == elementToDelete)
                        {
                            list.RemoveAt(i);
                            i--;
                        }
                    }

                }
                else if (elements[0] == "Insert")
                {
                    int elementToInsert = int.Parse(elements[1]);
                    int index = int.Parse(elements[2]);

                    list.Insert(index, elementToInsert);

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', list));
        }
    }
}