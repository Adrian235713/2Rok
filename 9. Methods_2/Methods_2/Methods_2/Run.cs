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
            Console.WriteLine(exercise.Exercise2(5,23.32,10));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(exercise.Exercise3(3,4,5));
            Console.WriteLine("---------------------------------------------");
            List<int> list = new List<int> {5,4,-10,100};
            Console.WriteLine(exercise.Exercise4(list));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(exercise.Exercise5(5.43));
            Console.WriteLine("---------------------------------------------");
            double[] xxx =  {5,6,7,8,10};
            exercise.Exercise6Iteration(exercise.Exercise6(xxx));
            Console.ReadKey();
        }
    }
}
