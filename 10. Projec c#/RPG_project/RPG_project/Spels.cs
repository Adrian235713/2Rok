using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spels
    {
        public static int[] SpelsBook(int[] character, int mxaHp, int maxMana)
        {
            Console.WriteLine("a - Lecznie");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "a":
                    return Heal(character,mxaHp,maxMana);
                default:
                    return character;
            }
        }

        public static int[] Heal(int[] character, int mxaHp, int maxMana)
        {
            if (character[2] >= 100)
            {
                character[0] = mxaHp;
                character[2] -= 100;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak many");
            }

            return character;
        }





    }
}
