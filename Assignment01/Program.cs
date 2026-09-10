/*
 * Student ID : 1690704273
 * Name       : Assignment 1 Stat Card
 * Section    : 129D
 * No.        : 17
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Goddess of Creation";  // const, PascalCase

            var heroName = "Cartethyia";     // var บน string — ต้องให้ compiler เดาชนิด
            var heroRank = "IMPOSSIBLE";         // var บน string  
            int heroLevel = 99999;  // int ต้องมีค่าเริ่มต้น
            int heroHealth = 5000000;  // int ต้องมีค่าเริ่มต้น
            int herodamage = 250000;  // int ต้องมีค่าเริ่มต้น
            string heroElement = "Wind"; // string ต้องใส่ double quote
            char heroGender = 'F'; // char ต้องใส่ single quote
            char herotype = 'A'; // char ต้องใส่ single quote
            float critChance = 95.75f;
            double critDamage = 300.0;  // ตัวอย่างค่า double
            double staminaPrecise = 250.75;  // เลขหลังจุดเป็น 5 ขึ้นไป
            bool isPlayable = true;
          


            Console.WriteLine("======================================");
            Console.WriteLine($"         {GameTitle}          ");
            Console.WriteLine("======================================");
            Console.WriteLine($" Hero Name    : {heroName}");
            Console.WriteLine($" Rank         : {heroRank}");
            Console.WriteLine($" Level        : {heroLevel}");
            Console.WriteLine($" Health       : {heroHealth}");
            Console.WriteLine($" Damage       : {herodamage}");
            Console.WriteLine($" Element      : {heroElement}");
            Console.WriteLine($" Gender       : {heroGender} (Female)");
            Console.WriteLine($" Type         : {herotype} (Attacker)");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($" Crit Chance  : {critChance}%");
            Console.WriteLine($" Crit Damage  : {critDamage}%");
            Console.WriteLine($" Stamina      : {staminaPrecise}");
            Console.WriteLine($" Playable     : {isPlayable}");
            Console.WriteLine("======================================");

            double heroLevelAsDouble = heroLevel; // implicit — ไม่มี cast
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;               // explicit cast
            int staminaRounded = Convert.ToInt32(staminaPrecise);      // Convert
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}