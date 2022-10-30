using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp7
{
    internal class Program
    {

        //Zad 1:
        //Napisz fukcje co policzą średnią charmniczną i arymetczną powyższej tablicy. 

        //rowiazanie 1
        static void sredniaAiH_1(double[,] tablica)
        {
            double sumaDoSredAr = 0;
            double sumaDoSredHar = 0;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    sumaDoSredAr += tablica[i, j];
                    sumaDoSredHar += 1 / tablica[i, j];
                }
            }
            Console.WriteLine(sumaDoSredAr / tablica.Length);
            Console.WriteLine(tablica.Length / sumaDoSredHar);
        }

        //Zad 2 ++
        //Napisz fukcje która powie ile wynoszą średnie poszczegulnych tablic z informacją o ich idexsach.


        static void zad2(double[,] tablica)
        {
            double sumaDoSredAr = 0;
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    sumaDoSredAr += tablica[i, j];
                }
                Console.WriteLine($" {i} - sr -  {sumaDoSredAr / tablica.GetLength(1)} ");

                sumaDoSredAr = 0;
            }

        }

        //Zad 3 ++
        //Napisz fukcje która zwróci max elemet znajdujacy się w tablicy

        static double zad3(double[,] tabela)
        {
            double myMax = tabela[0, 0];
            foreach (double x in tabela)
            {
                if (x > myMax)
                {
                    myMax = x;
                }
            }
            return myMax;
        }

        //Zad 4 ++
        //Napisz fukcje co przepisze liczby które są podziene przez k do nowej listy.
        //Fukcja ma zwracac tą liste. 
        //Napisz też fukcje co wyświtli wszystkie elementy ładnie sformatowane. 

        static List<double> zad4(double[,] table, double k)
        {
            List<double> list = new List<double>();
            foreach (double x in table)
            {
                if (x % k == 0)
                {
                    list.Add(x);
                }
            }
            return list;
        }

        static void zad4Vew(List<double> list)
        {
            foreach (double x in list)
            {
                Console.Write($"{x} \t");
            }
            Console.WriteLine();
        }

        //Zad 5 ++
        //Napisz fukcje która utwóży liste w liście (2 wymiary) o wymiatach takich jak tablica.
        //Wpełnij ją loswym elmetami.
        //Napisz też fukcje co wyświtli wszystkie elementy ładnie sformatowane.

        static List<List<double>> zad5(double[,] table)
        {
            List<List<double>> list = new List<List<double>>();
            Random rnd = new Random();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                List<double> l = new List<double>();
                list.Add(l);
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    list[i].Add(rnd.Next(1, 100));
                }
            }
            return list;
        }

        static void zad5_v (List<List<double>> list){

            for(int i = 0; i < list.Count; i++)
            {
                for(int j =0; j < list[i].Count; j++)
                {
                    Console.Write($"{list[i][j]} \t");
                }
                Console.WriteLine();

            }
        }

        //Zad 6 ++
        //Napisz fuckja która pozlwoli na wypełnienie listy double aż użytkowinik nie wpisze stop
        //Fukacje zwraca otrzymaną Liste 
        //Napisz też fukcje co wyświtli wszystkie elementy ładnie sformatowane. 

        static List<double> zad6()
        {
            Console.WriteLine("Add number / stop ");
            List<double> list = new List<double>();
            
            while (true) 
            {
                string inp = Console.ReadLine().ToLower();
                if(inp == "stop")
                {
                    break;
                }
                list.Add(double.Parse(inp));
            }
            return list;
        }

        static void zad6V(List<double> list)
        {
            foreach (double val in list)
            {
                Console.Write($"{val} \t");
            }
            Console.WriteLine();
        }


        //Zad 7 +++
        //Napisz fukje która stworzy liste w liscie o wymiarach n i m, i wypłni ja loswymi znakami graficznymi z zakresy (1 do 300).
        //Do tego polecnia zpoznaj sie z ASCI
        //Napisz też fukcje co wyświtli wszystkie elementy ładnie sformatowane. 

        static List<List<char>> zad7(int n, int m)
        {
            List<List<char>> lista = new List<List<char>>();
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                lista.Add(new List<char>());
                for(int j = 0; j < m; j++)
                {
                    lista[i].Add((char)rnd.Next(1,300));
                }
            }
            return lista;
        }

        static void zad7V(List<List<char>> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list[i].Count; j++)
                {
                    Console.Write($"{list[i][j]} \t");
                }
                Console.WriteLine();
            }
        }

        //Zad 8 +++
        //Napisz fukcje co co zpełni liste  (2 wymiarowom) n i m losowymi liczbam.
        //Napisz też fukcje co wyświtli otrzymaną tablice, wszystkie elementy ładnie sformatowane. 
        //Napisz fukcje co przelisze liczby pierwsze na liste. 
        //Napisz fukcje co wyświtli odtrzymaną liste.


        //Zad 9 +++
        //Napisz fuckje która wygneruje Liste w której będzie znjdowało k List. Każda o losowej wielkości i z losowym wartosciami z
        //zakresu 1 do 12. 
        //Wyświtl każdla z list znajdujacych się w srodku w jednej linijce z informacją o indeksie (fuckja)


        static void Main(string[] args)
        {

            double[,] tablica =
            {
                {10, 1 , 20},
                {10, 1 , 10},
                {10, 5 , 100}
            };
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 1");
            Console.WriteLine("-------------------------------------------------------------");
            sredniaAiH_1(tablica);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 2");
            Console.WriteLine("-------------------------------------------------------------");
            zad2(tablica);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 3");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(zad3(tablica));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 4");
            Console.WriteLine("-------------------------------------------------------------");
            zad4Vew(zad4(tablica,5));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 5");
            Console.WriteLine("-------------------------------------------------------------");
            zad5_v(zad5(tablica));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 6");
            zad6V(zad6());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 7");
            zad7V(zad7(5,3));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 8");

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Zad - 9");

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();





        }
    }
}
