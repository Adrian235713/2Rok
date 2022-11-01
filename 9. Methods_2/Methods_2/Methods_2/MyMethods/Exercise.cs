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
        public bool Exercise2(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b ? true : false;
        }
        public bool Exercise2(int a, int b, int c)
        {
            return a + b > c && b + c > a && c + a > b ? true : false;
        }
        //zad3.Napisz funkcję która liczy ze wzoru herona
        public double Exercise3(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)) / 2);
        }
        public double Exercise3(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)) / 2);
        }
        //zad4.Napisz funkcje co przyjmuje listę i zwraca największy element. 
        public double Exercise4(List<double> list)
        {
            double min = list[0];
            foreach (double elment in list)
            {
                min = (elment < min) ? elment : min;
            }
            return min;
        }

        public int Exercise4(List<int> list)
        {
            int min = list[0];
            foreach (int elment in list)
            {
                min = (elment < min) ? elment : min;
            }
            return min;
        }
        //zad5.Napisz funkcje co powie czy podana liczba jest liczba całkowita;

        public bool Exercise5(double a)
        {
            return a % 1 == 0 ? true : false;
        }

        public bool Exercise5(int a)
        {
            return true;
        }

        //zad6.Napisz funkcję co przekształci tablice na listę.

        public List<double> Exercise6(double[] area) 
        {
            List<double> list = new List<double>();
            foreach(double elment in area)
            {
                list.Add(elment);
            }
            return list;
        }

        public List<double> Exercise6(int[] area)
        {
            List<double> list = new List<double>();
            foreach (int elment in area)
            {
                list.Add(elment);
            }
            return list;
        }

        public void Exercise6Iteration(List<double> list)
        {
            foreach(double elment in list)
            {
                Console.Write($"{elment}\t");
            }
        }


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
