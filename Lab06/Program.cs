/*
 * Student ID : 1690704273
 * Name       : Lab06
 * Section    : 129D
 * No.        : 17
 * Course     : GI113 Computer Programming (GI)
 */
using System.ComponentModel.Design;

namespace LAB06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HeroHP = 100;
            int BASIC_PUNCHDMG = 20;
            int POWERFUL_KICKDMG = 40;
            int SPECIAL_ATTACKDMG = 70;
            int ULTIMATE_ATTACKDMG = 200;
            int HEALING = 20;
            string ESCAPE = "ESCAPE";
            int EnemyHP = 150;

            Console.WriteLine("GAME TITLE: FIGHTING OF GOD");
            Console.WriteLine();
            Console.WriteLine("CHOOSE YOUR NEXT MOVE ");
            Console.WriteLine("MOVE 1:BASIC PUNCH (20 DMG)");
            Console.WriteLine("MOVE 2:POWERFUL KICK (40 DMG)");
            Console.WriteLine("MOVE 3:SPECIAL ATTACK (70 DMG)");
            Console.WriteLine("MOVE 4:ULTIMATE ATTACK (200 DMG)");
            Console.WriteLine("MOVE 5:HEALING (20 HP)");
            Console.WriteLine("MOVE 6:ESCAPE ");
            Console.WriteLine();
            Console.Write("CHOOSE YOUR MOVE (1-6): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 6)
            {
                Console.WriteLine("INVALID MOVE. PLEASE CHOOSE A MOVE BETWEEN 1 AND 6.");
                return;
            }
            else if (choice == 1)
            {
                Console.WriteLine("YOU USED BASIC PUNCH!");
                EnemyHP -= BASIC_PUNCHDMG;
                if (EnemyHP <= 0)
                {
                    Console.WriteLine($"Enemy hit with BASIC PUNCH! took {BASIC_PUNCHDMG} damage. Enemy DIED!");
                }
                else
                {
                    Console.WriteLine($"Enemy hit with BASIC PUNCH! took {BASIC_PUNCHDMG} damage. Enemy HP has been reduced to: {EnemyHP}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("YOU USED POWERFUL KICK!");
                EnemyHP -= POWERFUL_KICKDMG;
                if (EnemyHP <= 0)
                {
                    Console.WriteLine($"Enemy hit with POWERFUL KICK! took {POWERFUL_KICKDMG} damage. Enemy DIED!");
                }
                else
                {
                    Console.WriteLine($"Enemy hit with POWERFUL KICK! took {POWERFUL_KICKDMG} damage. Enemy HP has been reduced to: {EnemyHP}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("YOU USED SPECIAL ATTACK!");
                EnemyHP -= SPECIAL_ATTACKDMG;
                if (EnemyHP <= 0)
                {
                    Console.WriteLine($"Enemy hit with SPECIAL ATTACK! took {SPECIAL_ATTACKDMG} damage. Enemy DIED!");
                }
                else
                {
                    Console.WriteLine($"Enemy hit with SPECIAL ATTACK! took {SPECIAL_ATTACKDMG} damage. Enemy HP has been reduced to: {EnemyHP}");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("YOU USED ULTIMATE ATTACK!");
                EnemyHP -= ULTIMATE_ATTACKDMG;
                if (EnemyHP <= 0)
                {
                    Console.WriteLine($"Enemy hit with ULTIMATE ATTACK! took {ULTIMATE_ATTACKDMG} damage. Enemy DIED!");
                }
                else
                {
                    Console.WriteLine($"Enemy hit with ULTIMATE ATTACK! took {ULTIMATE_ATTACKDMG} damage. Enemy HP has been reduced to: {EnemyHP}");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("YOU USED HEALING!");
                HeroHP += HEALING;
                Console.WriteLine($"You used HEALING! Restored {HEALING} HP. Your HP has been increased to: {HeroHP}");
            }
            else if (choice == 6)
            {
                Console.WriteLine("YOU ESCAPED FROM THE BATTLE !");
                Console.WriteLine();
                Console.WriteLine("GAME OVER !");
                return;
            }
                

        }

    }
}