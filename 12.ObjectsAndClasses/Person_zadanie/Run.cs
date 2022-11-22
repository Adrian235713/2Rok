using Person_zadanie.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Person_zadanie
{
    internal partial class Run
    {

        static void Main(string[] args)
        {
            Console.WriteLine("TEST 1 - empty object");
            Person TEST1 = new Person();
            TEST1.Information();

            Console.WriteLine("TEST 2 - wrong inputs ");
            Person TEST2 = new Person("", "", 0, height: 0, 0);
            TEST2.Information();

            Console.WriteLine("TEST 3 - The correct data ");
            Person TEST3 = new Person("Ala", "Alowata", 20, height: 190, 200);
            TEST3.Information();

            string s = "";
            Console.WriteLine(s.Length);

            //==========================================================================
            //Program 
            Console.WriteLine("Testujemy nasz program");
            //==========================================================================

            Live live = new Live();

            live.Persons.Add(TEST1);
            live.Persons.Add(TEST2);
            live.Persons.Add(TEST3);

            bool programWork = true;
            while (programWork)
            {
                Console.WriteLine("w - live progrma a - Add new person q - all data e - Edit personal data");
                Console.WriteLine("r - remove person");
                Console.WriteLine("sh - Medium height");
                string inp = Console.ReadLine().ToLower().Trim();
                switch (inp)
                {
                    case "w":
                        Console.Clear();
                        programWork = false;
                        break;
                    case "a":
                        Console.Clear();
                        live.AddPerson();
                        break;
                    case "q":
                        Console.Clear();
                        live.AllUsersInformation();
                        break;
                    case "e":
                        Console.Clear();
                        live.EditPersonalData();
                        break;
                    case "r":
                        live.RemovePerson();
                        break;
                    case "sh":
                        live.MediumHeight();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("There is no such command");
                        break;
                }
            }

            Console.WriteLine("Have a good day !!! and see you !!!");
            Console.ReadKey();
        }
    }
}
