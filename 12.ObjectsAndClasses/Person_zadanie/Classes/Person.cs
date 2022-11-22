using System;
using System.Collections.Generic; 

namespace Person_zadanie.Classes
{
    internal class Person
    {
        //Napisz klasę, która tworzy osobę.(id, imie, nazwisko wiek, wzrost, wagę, IQ, lista umiejętności; Wykonaj walidację  danych get i set)
        public string Id;
        public string name;
        public string lastName;
        public int age;
        public double height;
        public int iq;

        //Konstuktory 
        public Person(string name, string lastName, int age, double height, int iq)
        {
            Id = generateUniqueID();
            Name = name;
            LastName = lastName;
            Age = age;
            Height = height;
            Iq = iq;
        }

        public Person()
        {
            Id = generateUniqueID();
            Name = "";
            LastName = "";
            Age = 0;
            Height = 0;
            Iq = 0;
        }

        // A czemu nie mogę poprostu? Overloading zrobić ? 

        //public Person()
        //{

        //}

        // PROPERTIES  validation 

        //Get i set sie wtedy nie odpali XD 

        //----------------------------------------------------------------------------
        //Let's generate unique ID

        private string generateUniqueID()
        {
            long ticks = DateTime.Now.Ticks;
            // Gets the number of ticks that represent the date and time of this instance.
            string guid = Guid.NewGuid().ToString();
            //This is a convenient static method that you can call to get a new Guid.
            //The method creates a Version 4 Universally Unique Identifier
            //(UUID) as described in RFC 4122, Sec. 4.4.
            //The returned Guid is guaranteed to not equal Guid.Empty.
            return ticks.ToString() + "-" + guid;
        }

        //----------------------------------------------------------------------------
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length >= 20 || String.IsNullOrEmpty(value))
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
                if (value.Length >= 20 || String.IsNullOrEmpty(value))
                    lastName = "WRONG INPUT";
                else
                {
                    lastName = value;
                }
            }
        }

        public int? Age
        {
            get { return age; }
            set 
            { 
                if(value >= 155 || value <= 0 || value == null)
                    age = -1;
                else
                {
                    age = (int)value;
                }
            }
        }

        public double? Height
        {
            get { return height; }
            set
            {
                if (value >= 350 || value <= 100 || value == null)
                    height = -1;
                else
                {
                    height = (double)value;
                }
            }
        }

        public int? Iq
        {
            get { return iq; }
            set
            {
                if(value <= 30 || value >= 350 || value == null)
                {
                    iq = -1;
                }
                else
                {
                    iq = (int)value;
                }
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

        public void ChangeName()
        {
            Console.WriteLine("New name ?");
            string inp = Console.ReadLine();
            Console.WriteLine($"Odl Name {Name} -> New name {inp}");
            Name = inp;
        }

        public void ChangeLastName()
        {
            Console.WriteLine("New Last Name ?");
            string inp = Console.ReadLine();
            Console.WriteLine($"Old LastName {lastName} -> New name {inp}");
            LastName = inp;
        }

        public void ChangeAge()
        {
            Console.WriteLine("New Age ?");
            int inp = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Old Age  {age} -> New age {inp}");
            age = inp;
        }

        public void ChangeHeight()
        {
            Console.WriteLine("New Height ?");
            double inp = Int64.Parse(Console.ReadLine());
            Console.WriteLine($"Old Height  {height} -> New age {inp}");
            height = inp;
        }

        public void ChangeIq()
        {
            Console.WriteLine("New iq");
            int inp = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Old Iq  {iq} -> New age {inp}");
            iq = inp;
        }

    }
}
