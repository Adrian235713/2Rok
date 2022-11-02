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
            foreach (double elment in area)
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
            foreach (double elment in list)
            {
                Console.Write($"{elment}\t");
            }
            Console.WriteLine();
        }
        //zad7.Napisz funkcję co generuje generuje tabelę z losowymi wartościami z przedziału k i b

        public int[] Exercise7(int k, int b)
        {
            Random rnd = new Random();
            int[] array = new int[rnd.Next(10, 20)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(k, b);
            }
            return array;
        }

        public void Exercise7Iteration(int[] array)
        {
            foreach (int elment in array)
            {
                Console.Write($"{elment} ");
            }
            Console.WriteLine();
        }
        //zad8.Napisz funkcję co przyjmuje(2 argumenty ) stringa np 6,8,10,12 i n.
        //Na podstawie tego wyświetli n elementów (w jednej linijce ciągu arytmetycznego).

        public void Exercise8(string inp, int n)
        {
            string[] array = inp.Split(',');
            int element1 = int.Parse(array[0]);
            int element2 = int.Parse(array[1]);
            int increase = element2 - element1;
            Console.Write($"{element1} ");
            while (n > 0)
            {
                Console.Write($"{element1 + increase} ");
                element1 += increase;
                n--;
            }
            Console.WriteLine();
        }

        //zad9.Napisz funkcję co przyjmuje(2 argumenty) syringa np 3,9,27,81  i n.
        //Na tej podstawie wyświetli n elementów tego ciągu (w jednej linijce)

        public void Exercise9(string inp, int n)
        {
            string[] array = inp.Split(',');
            double el1 = double.Parse(array[0]);
            double el2 = double.Parse(array[1]);
            double q = el2 / el1;
            Console.Write($"{el1} ");
            while (n > 0)
            {
                Console.Write($"{el1 * q} ");
                el1 *= q;
                n--;
            }
            Console.WriteLine();
        }

        //zad10.Napisz funkcję no wyświetli n elementów ciągu Fibonacciego. 1 1 2 3 5 8 13 21... 

        public void Exercise10(int n)
        {
            int a = 1;
            int b = 1;
            int c;
            Console.Write("1 1 ");
            while (n > 0)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                n--;

            }
            Console.WriteLine();
        }

    }
}
