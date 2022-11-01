using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2.MyMethods
{
    public class Exercise
    {
        //zad1.Napisz funkcje co zwraca która z liczb podanych jako argumenty jest większa.
        public double Exercise1(double a, double b)
        {
            if (a > b)
                return a;
             return b;
        }

        //Overloading
        public double Exercise1(int a, int b)
        {
            int result = (a > b) ? a : b;
            return result;
        }
        //zad2.Napisz funkcje co przyjmuje trzy argumenty i zwraca (true lub false) - czy da się zrobić trójkąt.
        //public boo Exercise2(double a, double b, double c)
        //{

        //}


        //zad3.Napisz funkcję która liczy ze wzoru herona

        //zad4.Napisz funkcje co przyjmuje listę i zwraca największy element. 


        //zad5.Napisz funkcje 2 argumenty (tablice i n) i powie ile n elementów znajduje się w tej tablicy.

        //zad6.Napisz funkcję co przekształci tablice na listę.


        //zad7.Napisz funkcję co generuje generuje tabelę z losowymi wartościami z przedziału k i b


        //zad8.Napisz funkcję co przyjmuje(2 argumenty ) syringa np 6,8,10,12 i n.
        //Na podstawie tego wyświetli n elementów (w jednej linijce ciągu arytmetycznego).

        //zad9.Napisz funkcję co przyjmuje(2 argumenty ) syringa np 3,9,27, 81  i n.
        //Na tej podstawie wyświetli n elementów tego ciągu (w jednej linijce)

        //zad10.Napisz funkcję no wyświetli n elementów ciągu Fibonacciego.

        //zad11.Napisz funkcję która prosi o podanie stringu i n (różnych liter). 
        //Niech funkcja wyświetli ile jakich liter znajduje się w podanym stringu.
    }
}
