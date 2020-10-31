using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string[] command = new string[2];
            while (command[0] != "End")
            {
                command = Console.ReadLine().Split().ToArray();
                if (command[0] == "End")
                {
                    break;
                }

                Person student = new Person(command[0], command[1], int.Parse(command[2]));
                people.Add(student);
            }
            Console.WriteLine(String.Join(Environment.NewLine,
                people.OrderBy(x => x.YearsOld)));

        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string ID { get; set; }
        public int YearsOld { get; set; }
        public Person(string firstname, string id, int yearsold)
        {
            this.FirstName = firstname;
            this.ID = id;
            this.YearsOld = yearsold;
        }
        public override string ToString()
        {
            return $"{FirstName} with ID: {ID} is {YearsOld} years old.";
        }
    }

}
