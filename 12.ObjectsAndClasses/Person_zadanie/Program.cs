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
    internal class Program
    {

        //Napisz klasę, która tworzy osobę.(id, imie, nazwisko wiek, wzrost, wagę, IQ, lista umiejętności; Wykonaj walidację  danych get i set)
        //Napisz klasę starzenie.Która modyfikuję tę osobę.
        //Napisz klasę, życie co będzie obsługiwała n.osób (lista) i pozwoli na modyfikować dane wszystkich użytkowników.
        static void Main(string[] args)
        {
            Console.WriteLine("TEST 1 - empty object");
            Person TEST1 = new Person();
            TEST1.Information();

            Console.WriteLine("TEST 2 - wrong inputs ");
            Person TEST2 = new Person("", "", 0, height: 0,0);
            TEST2.Information();

            Console.WriteLine("TEST 3 - The correct data ");
            Person TEST3 = new Person("Ala", "Alowata", 20, height: 190, 200);
            TEST3.Information();

            string s = "";
            Console.WriteLine(s.Length);








            Console.ReadKey();
        }
    }
}
