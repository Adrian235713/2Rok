using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Person_zadanie.Classes
{
    internal class Live
    {
        public List<Person> Persons = new List<Person>();

        public void AddPerson()
        {
            try
            {
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("LastName");
                string lastName = Console.ReadLine();
                Console.WriteLine("Age");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Height");
                double height = Int64.Parse(Console.ReadLine());
                Console.WriteLine("Iq");
                int iq = Int32.Parse(Console.ReadLine());
                Person person = new Person(name, lastName, age, height, iq);
                Persons.Add(person);
            } catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void AllUsersInformation()
        {
            foreach (Person person in Persons)
            {
                person.Information();
            }
        }

        public void EditPersonalData()
        {
            Console.WriteLine("Plis enter ID person");
            string id = Console.ReadLine().Trim();
            bool exist = false;
            foreach (Person person in Persons)
            {
                if (person.Id == id)
                {
                    exist = true;
                    Console.WriteLine("The specified ID has been found");
                    bool edit = true;
                    while (edit)
                    {
                        Console.Clear();
                        person.Information();
                        Console.WriteLine("What do you want to change ?");
                        Console.WriteLine("a - name b - last name c - age l - live ");
                        Console.WriteLine("h - height iq - Iq");
                        string inp = Console.ReadLine().Trim().ToLower();
                        switch (inp)
                        {
                            case "a":
                                person.ChangeName();
                                Console.WriteLine("Click enter to continue");
                                Console.ReadKey();
                                break;
                            case "b":
                                person.ChangeLastName();
                                Console.WriteLine("Click enter to continue");
                                Console.ReadKey();
                                break;
                            case "c":
                                person.ChangeAge();
                                Console.WriteLine("Click enter to continue");
                                Console.ReadKey();
                                break;
                            case "h":
                                person.ChangeHeight();
                                Console.WriteLine("Click enter to continue");
                                Console.ReadKey();
                                break;
                            case "iq":
                                person.ChangeIq();
                                Console.WriteLine("Click enter to continue");
                                Console.ReadKey();
                                break;
                            case "l":
                                edit = false;
                                break;
                            default:
                                Console.WriteLine("The specified command does not exist");
                                Console.WriteLine("Click enter to continue");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
            }
            if (!exist)
            {
                Console.WriteLine("The person with the given ID does not exist");
            }
        }

        public void RemovePerson()
        {
            Console.Clear();
            Console.WriteLine("Enter the ID of the person you want to remove");
            string inp = Console.ReadLine().Trim().ToLower();
            int i = 0;
            foreach (Person person in Persons) 
            {
                i++;
                if (inp == person.Id)
                {
                    Console.WriteLine("The person with the given id exists");
                    person.Information();
                    Console.WriteLine("==========================================================");
                    Random rnd = new Random();
                    int v = rnd.Next(1,1000);
                    Console.WriteLine($"If you want to remove this person, enter {v}");
                    int confirmation = Int32.Parse(Console.ReadLine());
                    if (confirmation == v)
                    {
                        Persons.RemoveAt(i);
                        Console.WriteLine("The person has been removed");
                        break;
                    }
                }
            }
            Console.WriteLine("Operation failed. Make sure the Id has been entered correctly");
        }
        public static void MediumHeight(List<Person> lista)
        {
            double suma = 0;
            foreach (Person person in lista)
            {
                suma += person.height;
            }
            Console.WriteLine($"MediumHeight \t {suma / lista.Count}");
        }

        public void MediumHeight()
        {
            Console.Clear();
            double suma = 0;
            foreach (Person person in Persons)
            {
                suma += person.height;
            }
            Console.WriteLine($"MediumHeight \t {suma / Persons.Count}");
        }
    }
}
