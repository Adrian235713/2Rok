using System;
using System.Collections.Generic;

namespace Person_zadanie.Classes
{
    internal class Person
    {
        //Napisz klasę, która tworzy osobę.(id, imie, nazwisko wiek, wzrost, wagę, IQ, lista umiejętności; Wykonaj walidację  danych get i set)
        public int Id;
        public string name;
        public string lastName;
        public int age;
        public double height;
        public int iq;
        public new List<string> Skills = new List<string>();

        public Person(int id, string name, string lastName, int age, double height, int iq)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            Height = height;
            Iq = iq;
        }

        public Person()
        {

        }

        // Propertys validation 
        //----------------------------------------------------------------------------
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length >= 20 || value.Length < 1)
                    name = "WRONG INPUT";
                else
                {
                    name = value;
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length >= 20 || value.Length < 1)
                    lastName = "WRONG INPUT";
                else
                {
                    lastName = value;
                }
            }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                if(value >= 155 || value <= 0)
                    age = 0;
                age = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 350 || value <= 0)
                    height = 0;
                height = value;
            }
        }

        public int Iq
        {
            get { return iq; }
            set
            {
                if(value <= 30 || value >= 350)
                {
                    iq = 0;
                }
                iq = value;
            }
        }
        //----------------------------------------------------------------------------

        public void Information()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Id\t\t{Id}");
            Console.WriteLine($"Name\t\t{Name}");
            Console.WriteLine($"LastName\t{LastName}");
            Console.WriteLine($"Age\t\t{Age}");
            Console.WriteLine($"Height\t\t{Height}");
            Console.WriteLine($"Iq\t\t{Iq}");
            Console.WriteLine("=======================================");
        }




    }
}
