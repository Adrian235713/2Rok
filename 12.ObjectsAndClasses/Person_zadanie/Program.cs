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
            Console.WriteLine("TEST");
            Person TEST = new Person();
            TEST.Information();



            string x = "fgdgsdfgdfsgdfsgdfsgdfsgdfsgdfgdfsg";
            Console.WriteLine(x.Length);

            Console.ReadKey();
        }
    }
}
