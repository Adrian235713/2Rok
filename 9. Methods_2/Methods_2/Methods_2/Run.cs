using Methods_2.MyMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Run
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            //zad1.Napisz funkcje co zwraca która z liczb podanych jako argumenty jest większa.
            //Overloading
            Console.WriteLine(exercise.Exercise1(20,10));
            Console.WriteLine(exercise.Exercise1(20.2323, 10.32));
            Console.WriteLine("---------------------------------------------");

            Console.ReadKey();
        }
    }
}
