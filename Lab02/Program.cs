/*
 * Student ID : 1690704273
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace LAB02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            int speed = 20;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //LAb02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP percent : {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER TAKING DAMAGE =====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP percent : {hpPercent}%");
            Console.WriteLine();         // LAb02 Part B
            string bossName2 = "Jonathan";
            char rank2 = 'A';
            int speed2 = 15;
            int level2 = 5;
            int maxHp2 = 300;
            int currentHp2 = 250;
            float attackPower2 = 45.5f;
            double critMultiplier2 = 1.5;
            bool isBoss2 = true;
            Console.WriteLine("====== BOSS STATUS: INITIAL (BOSS 2) ======");
            Console.WriteLine($"Name: {bossName2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"HP: {currentHp2}/{maxHp2}");
            Console.WriteLine($"Speed: {speed2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Boss: {isBoss2}");
            Console.WriteLine();
            int hpPercent2 = currentHp2 * 100 / maxHp2;
            Console.WriteLine($"HP percent : {hpPercent2}%");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER TAKING DAMAGE =====");
            Console.WriteLine($"HP: {currentHp2}/{maxHp2}");
            hpPercent2 = currentHp2 * 100 / maxHp2;
            Console.WriteLine($"HP percent : {hpPercent2}%");
            Console.WriteLine();         
            string bossName3 = "Rayna";
            char rank3 = 'B';
            int level3 = 4;
            int maxHp3 = 150;
            int currentHp3 = 120;
            int speed3 = 10;
            float attackPower3 = 32.5f;
            double critMultiplier3 = 1.25;
            bool isBoss3 = true;
            Console.WriteLine("====== BOSS STATUS: INITIAL (BOSS 3) ======");
            Console.WriteLine($"Name: {bossName3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine($"HP: {currentHp3}/{maxHp3}");
            Console.WriteLine($"Speed: {speed3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier3}");
            Console.WriteLine($"Is Boss: {isBoss3}");
            Console.WriteLine();
            int hpPercent3 = currentHp3 * 100 / maxHp3;
            Console.WriteLine($"HP percent : {hpPercent3}%");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER TAKING DAMAGE =====");
            Console.WriteLine($"HP: {currentHp3}/{maxHp3}");
            hpPercent3 = currentHp3 * 100 / maxHp3;
            Console.WriteLine($"HP percent : {hpPercent3}%");
            Console.WriteLine();
            string bossName4 = "Steve";
            char rank4 = 'C';
            int level4 = 3;
            int maxHp4 = 80;
            int currentHp4 = 50;
            int speed4 = 8;
            float attackPower4 = 15.7f;
            double critMultiplier4 = 1.1;
            bool isBoss4 = true;
            Console.WriteLine("====== BOSS STATUS: INITIAL (BOSS 4) ======");
            Console.WriteLine($"Name: {bossName4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Level: {level4}");
            Console.WriteLine($"HP: {currentHp4}/{maxHp4}");
            Console.WriteLine($"Speed: {speed4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier4}");
            Console.WriteLine($"Is Boss: {isBoss4}");
            Console.WriteLine();
            int hpPercent4 = currentHp4 * 100 / maxHp4;
            Console.WriteLine($"HP percent : {hpPercent4}%");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER TAKING DAMAGE =====");
            Console.WriteLine($"HP: {currentHp4}/{maxHp4}");
            hpPercent4 = currentHp4 * 100 / maxHp4;
            Console.WriteLine($"HP percent : {hpPercent4}%");
            Console.WriteLine();
            string bossName5 = "Rimuru";
            char rank5 = 'F';
            int level5 = 1;
            int maxHp5 = 30;
            int currentHp5 = 12;
            int speed5 = 5;
            float attackPower5 = 10.5f;
            double critMultiplier5 = 1.3;
            bool isBoss5 = true;
            Console.WriteLine("====== BOSS STATUS: INITIAL (BOSS 5) ======");
            Console.WriteLine($"Name: {bossName5}");
            Console.WriteLine($"Rank: {rank5}");
            Console.WriteLine($"Level: {level5}");
            Console.WriteLine($"HP: {currentHp5}/{maxHp5}");
            Console.WriteLine($"Speed: {speed5}");
            Console.WriteLine($"Attack Power: {attackPower5}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier5}");
            Console.WriteLine($"Is Boss: {isBoss5}");
            Console.WriteLine();
            int hpPercent5 = currentHp5 * 100 / maxHp5;
            Console.WriteLine($"HP percent : {hpPercent5}%");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER TAKING DAMAGE =====");
            Console.WriteLine($"HP: {currentHp5}/{maxHp5}");
            hpPercent5 = currentHp5 * 100 / maxHp5;
            Console.WriteLine($"HP percent : {hpPercent5}%");
            Console.WriteLine();
        }
    }
}

