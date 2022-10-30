using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Shop
    {
        public static int[] shop(int[] character, int maxMana, int mxaHp)
        {
            Console.WriteLine("Witaj w moim sklepie!!!");
            Console.WriteLine("1 - heal 2g \t 2 - upHp - 5g \t 3 - upAtac 3g \t 4 - upMana 3g \t dowolny klawisz - wyjdz");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, mxaHp);
                case 2:
                    return upHp(character);
                case 3:
                    return upAtac(character);
                case 4:
                    return upMana(character);
            }
            Console.WriteLine("Wychodzisz ze sklepu");
            return character;
        }

        public static int[] heal(int[] character, int mxaHp)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10,20);
            Console.WriteLine(character[0]);
            if (character[3] >= 2)
            {
                Console.WriteLine("Płacisz 2 g");
                character[3] -= 2;
                if (character[0] + heal >= mxaHp)
                {
                    Console.WriteLine("Masz max hp");
                    character[0] = mxaHp;
                    return character;
                }
                else 
                {
                    Console.WriteLine($"uleczono cie o {heal} masz {character[0]}hp");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("Nie stac sie");
            return character;
        }

        public static int[] upHp(int[] character)
        {

            return character;
        }

        public static int[] upAtac(int[] character)
        {

            return character;
        }

        public static int[] upMana(int[] character)
        {

            return character;
        }
    }
}
