using System;
using System.Linq;

namespace Experimenting
{
    class Program
    {
        static string playerName;

        static void Main(string[] args)
        {
            GetPlayerName();

            Console.WriteLine($"Greetings, {playerName}");
            Console.WriteLine("Hit any key to kick ass!");            
            Console.ReadKey();

            Console.WriteLine();

            string[] weapon = new string[5];
            weapon[0] = "Sword";
            weapon[1] = "Axe";
            weapon[2] = "Dagger";
            weapon[3] = "Bow";
            weapon[4] = "Spear";

            Random randomWeapon = new Random();
            Random randomDamage = new Random();

            for (int i = 0; i < weapon.Length; i++)
            {
                int weaponType = randomWeapon.Next(0, 5);
                int damage = randomDamage.Next(1, 21);

                Console.WriteLine($"{playerName} hits the enemy with the {weapon[weaponType]} for {damage} damage");
            }
        }

        public static void GetPlayerName()
        {
            string inputName;

            bool incorrect = true;
            while (incorrect)
            {
                Console.WriteLine("Please enter your Player Name");
                inputName = Console.ReadLine();

                if (inputName.All(Char.IsLetter))
                {
                    playerName = inputName;
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Alphabetic characters only please!");
                }              
            }            
        }
    }
}
