using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InheritanceInterfaceAbstraction.Student
{
    internal class Person : InterfacePerson
    {
        private string Name;
        private string LastName;
        private int Age;
        private int PersonalID;
        private bool Daily;

        private List<int> Mathematics = new List<int>();
        private List<int> Physics = new List<int>();
        private List<int> English = new List<int>();

        public Person(string name, string lastName, int age, int personalID, bool daily)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            PersonalID = personalID;
            Daily = daily;
        }

        public virtual void Informations()
        {
            Console.Clear();
            Console.WriteLine($"Name \t {Name}");
            Console.WriteLine($"LastName \t {LastName}");
            Console.WriteLine($"Age \t {Age}");
            Console.WriteLine($"PersonalID \t {PersonalID}");
            Console.WriteLine($"Daily \t {Daily}");
        }

        public virtual void ChangePersonalData()
        {
            Console.Clear();
            Console.WriteLine($"Name \t {Name} LastName \t {LastName}");
            Console.WriteLine($"Age \t {Age}");
            Console.WriteLine($"PersonalID \t {PersonalID}");
            Console.WriteLine($"=========================================================");
            Console.WriteLine($"To change the value: ");
            Console.WriteLine($"n - Name ln - LastName ag - Age id - PersonalID ll - Lile");
            Console.WriteLine($"=========================================================");

            bool run = true;
            while (run)
            {
                string inp = Console.ReadLine().ToLower().Trim();
                switch (inp)
                {
                    case "n":
                        break;
                    case "ln":
                        break;
                    case "ag":
                        break;
                    case "id":
                        break;
                    case "ll":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("There is no such command");
                        break;
                }
            }
            Console.WriteLine($"=========================================================");
        }
    }
}
