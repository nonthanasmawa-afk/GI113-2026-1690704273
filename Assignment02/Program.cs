/*
 * Student ID : 1690704273
 * Name       : Assignment02
 * Section    : 129D
 * No.        : 17
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string Material1 = " IRON ";
            const double SmeltRate1 = 0.20;
            const double SalvageRate1 = 0.25;

            const string Material2 = " GOLD ";
            const double SmeltRate2 = 0.10;
            const double SalvageRate2 = 0.20;

            const double MaxBatch = 100.0;

           
            Console.WriteLine("SELECT MATERIAL TO FORGE");
            Console.WriteLine();
            Console.WriteLine("[1] IRON (Smelt: 0.20, Salvage: 0.25)");
            Console.WriteLine("[2] GOLD (Smelt: 0.10, Salvage: 0.20)");
            Console.WriteLine();
            Console.Write("Choose material (1 or 2): ");
            bool isMaterialValid = int.TryParse(Console.ReadLine(), out int materialChoice);

            
            if (!isMaterialValid || (materialChoice != 1 && materialChoice != 2))
            {
                Console.WriteLine(" Error: Invalid material selection! Please choose 1 or 2. ");
            }
            else
            {
                
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine("SELECT ACTION");
                Console.WriteLine();
                Console.WriteLine("[S] Smelt (Ore -> Ingots)");
                Console.WriteLine("[B] Breakdown (Ingot -> Ore)");
                Console.WriteLine();
                Console.WriteLine("==================================");
                Console.Write(" Choose Action (S or B): ");
                bool isMenuValid = char.TryParse(Console.ReadLine(), out char menu);

                if (!isMenuValid || (menu != 'S' && menu != 's' && menu != 'B' && menu != 'b'))
                {
                    Console.WriteLine(" Error: Invalid menu selection! Please enter 'S','s'  or  'B','b'.");
                }
                else
                {
                    Console.Write("Enter Amount: ");
                    bool isAmountValid = double.TryParse(Console.ReadLine(), out double amount);

                    
                    if (!isAmountValid || amount <= 0 || amount > MaxBatch)
                    {
                        Console.WriteLine($"Error: Invalid amount! Please enter a number between 1 to {MaxBatch}.");
                    }
                    else
                    {
                        
                        double smeltRate = (materialChoice == 1) ? SmeltRate1 : SmeltRate2;
                        double salvageRate = (materialChoice == 1) ? SalvageRate1 : SalvageRate2;
                        string materialName = (materialChoice == 1) ? Material1 : Material2;

                        if (menu == 'S' || menu == 's')
                        {
                            double result = amount * smeltRate;
                            Console.WriteLine();
                            Console.WriteLine($"Smelt Successful! You processed {amount:F2} {materialName} Ore and received {result:F2} Ingot.");
                        }
                        else if (menu == 'B' || menu == 'b')
                        {
                            double result = amount / salvageRate;
                            Console.WriteLine();
                            Console.WriteLine($"Breakdown Successful! You processed {amount:F2} {materialName} Ingot and received {result:F2} Ore.");
                        }
                    }
                }
            }
        }
    }
}