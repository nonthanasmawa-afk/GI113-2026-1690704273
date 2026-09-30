/*
 * Student ID : 1690704273
 * Name       : LAB05
 * Section    : 129D
 * No.        : 17
 * Course     : GI113 Computer Programming (GI)
 */
namespace LAB05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title , Subtitle 
            Console.WriteLine("==>> MY VIDEO GAME IS VERY GOOD<<==");
            Console.WriteLine("Hero vs Monster -- Fight Damage Calculator");
            // Hero Stats input HP ATK DEF
            Console.WriteLine("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);
            // Monster Stats input
            Console.WriteLine("Monster Health: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster Attack: ");
            bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("Monster Defense: ");
            bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);
            // Input validation / output
            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterStatValid = monsterHpOk && monsterAtkOk && monsterDefOk;
            Console.WriteLine($"Hero Stats Valid: {heroStatValid}");
            Console.WriteLine($"Monster Stats Valid: {monsterStatValid}");

            Console.WriteLine($"[HERO]   HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

            // Compound Assign & Arithmetic ( + ) 
            int potionHeal = 20;
            // Hero drinks a potion and heals 20 HP
            heroHp += potionHeal; // นำ Hp Hero + potionHeal
            Console.WriteLine();
            Console.WriteLine($"Hero drinks a potion and heals {potionHeal} HP. Hero HP: {heroHp}");

            // Normal Attack RPG 
            int normalDmg = Math.Max(0, heroAtk - monsterDef);// Hero ATK - Monster DEF
            Console.WriteLine($"Hero would deal normal attack: {normalDmg}");
            // Power Attack
            int powerDmg = Math.Max(0, (heroAtk * 2) - monsterDef); // Hero ATK * 2 - Monster DEF
            Console.WriteLine($"Hero would deal power attack: {powerDmg}");
            // Random Critical Hit Chance
            Random rng = new Random();
            int critRoll  = rng.Next(1, 101); // สุ่มจาก 100
            bool isCrit = critRoll <= 99; // 99% chance

            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg; // ถ้าอยากได้ x2
            Console.WriteLine($"Crit roll: {critRoll}, Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit, Hero would deal: {critDmg}");
        }
    }
}
