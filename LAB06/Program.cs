/*
 * Student ID : 1690704273
 * Name       : Lab06
 * Section    : 129D
 * No.        : 17
 * Course     : GI113 Computer Programming (GI)
 */
namespace LAB06
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            //int level = 12;
            Console.WriteLine("Your level (1-99) : ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int level); // เช็คว่าเป็นตัวเลขหรือไม่
            bool hasKey = true; // สมมติว่าผู้เล่นมี key อยู่แล้ว
            if (!inputValid || level < 1 || level > 99) // เช็คว่าเป็นตัวเลขหรือไม่ และอยู่ในช่วง 1-99
            {
                Console.WriteLine(" Invalid level. ");
            }
            else if (level >= 10 && hasKey)
            {
                Console.WriteLine(" Boss floor unlocked ");
            }
            else if (level >= 5)
            {
                if (hasKey)
                {
                    Console.WriteLine(" The door opens ");
                }
                else
                {
                    Console.WriteLine(" You need a key to unlock the boss floor ");
                }
            }
            else
            {
                Console.WriteLine(" The door stays shut ");
            }
               
            }
        }
    }

