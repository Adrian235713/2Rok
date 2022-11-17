using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _12.ObjectsAndClasses
{
    internal class Program
    {
        public class Car1
        {
            public double Speed;

            //Overloading konstruktor 
            //-------------------------------
            public Car1(double speed)
            {
                Speed = speed;
            }

            public Car1()
            {

            }
            //-------------------------------
            public void CarInf()
            {
                Console.WriteLine($"Speed {Speed}");
            }
        }
        //================================================
        public class Car2
        {
            public double speed;

            public Car2(double speed)
            {
                Speed = speed;
            }

            // ? Powala nam na korzystanie z null
            public double? Speed
            {
                get { return speed; }
                set
                {
                    if (value >= 500)
                    {
                        speed = -1;
                    }
                    else
                    {
                        speed = (double)value;
                    }
                }
            }
            public void carInf()
            {
                Console.WriteLine($"Speed {Speed}");
            }
        }

        //================================================

        static void Main(string[] args)
        {
            //================================================
            //Car1
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Clas Car 1 ");
            Console.WriteLine("-----------------------------");
            //================================================
            Car1 aaaCar1 = new Car1();
            Car1 bbbCar1 = new Car1(99999);
            aaaCar1.CarInf();
            bbbCar1.CarInf();

            //================================================
            //Car2
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Clas Car 2 ");
            Console.WriteLine("-----------------------------");
            //================================================
            Car2 aaaCar2 = new Car2(100);
            Car2 bbbCar2 = new Car2(9999999);
            aaaCar2.Speed = 1000;
            aaaCar2.carInf();
            bbbCar2.carInf();

            Console.ReadKey();
        }
    }
}
