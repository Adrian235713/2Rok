using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class CharacterClass
    {

        public static int[] characterClassSelection()
        {
            // hp atack mana gold 
            while (true)
            {
                Console.WriteLine("Paladin - a \t Warrior -b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    int[] m = { 100, 10, 300, 20 };
                    return m;
                }
                else if (inp == "b")
                {
                    int[] w = { 300, 30, 0, 20};
                    return w;
                }
                else
                {
                    Console.WriteLine("Brak takiej klasy");
                }
            }
        }
        //---------------------------------------------------------
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}
