using ConsoleApp7;
using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        /*
        Thor Attacks Hulk and Deals 74 Damage
        Maximus Has 69 Health
 
        Hulk Attacks Thor and Deals 6 Damage
        Bob Has 6 Health
 
        Thor Attacks Hulk and Deals 48 Damage
        Maximus Has 21 Health
 
        Hulk Attacks Thor and Deals 48 Damage
        Bob Has -42 Health
 
        Thor has Died and Hulk is Victorious
 
        Game Over
        */

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the fight contender!\n" +
                "You Gonna choose the characteristics of two warriors that gonna fight for the death!");

            void GetWarriorInfo()
            {
                Warrior? warriorA = null;
                Warrior? warriorB = null;
                string warriorAName, warriorBName, warriorAClass, warriorBClass;
                double warriorAHealth, warriorBHealth, warriorADamage, warriorBDamage, warriorABlock, warriorBBlock;
                string[] warriorOptions = { "Warrior", "Mage" };

                warriorAName = GetValidName("warrior A");
                warriorAClass = GetValidClass(warriorAName, warriorOptions);

                Console.WriteLine($"Now {warriorAName} is a {warriorAClass}");

                warriorAHealth = GetValidDoubleInput($"Enter {warriorAName}'s health:");
                warriorADamage = GetValidDoubleInput($"Enter {warriorAName}'s damage:");
                warriorABlock = GetValidDoubleInput($"Enter {warriorAName}'s block:");

                Console.WriteLine("-----------------------------------\n");

                warriorBName = GetValidName("warrior B");
                warriorBClass = GetValidClass(warriorBName, warriorOptions);

                Console.WriteLine($"Now {warriorBName} is a {warriorBClass}");

                warriorBHealth = GetValidDoubleInput($"Enter {warriorBName}'s health:");
                warriorBDamage = GetValidDoubleInput($"Enter {warriorBName}'s damage:");
                warriorBBlock = GetValidDoubleInput($"Enter {warriorBName}'s block:");

                Console.WriteLine($"{warriorAName} is a {warriorAClass}, " +
                    $"has a total of {warriorAHealth} max health, " +
                    $"can do a max of {warriorADamage} damage and can block a total of {warriorABlock} damage.\n");
                Console.WriteLine($"{warriorBName} is a {warriorBClass}, " +
                    $"has a total of {warriorBHealth} max health, " +
                    $"can do a max of {warriorBDamage} damage and can block a total of {warriorBBlock} damage.\n");


                Console.WriteLine("Let the Battle Begins!!!\n");


                // Hero  = Warrior(name, health, damage dealing, damage block); keep simple, short and understandable

                // Call different functions based on warrior class
                if (warriorAClass.Equals("Warrior", StringComparison.OrdinalIgnoreCase))
                {
                    warriorA = new Warrior(warriorAName, warriorAHealth, warriorADamage, warriorABlock);
                }
                else if (warriorAClass.Equals("Mage", StringComparison.OrdinalIgnoreCase))
                {
                    warriorA = new MagicWarrior(warriorAName, warriorAHealth, warriorADamage, warriorABlock, 50);
                }

                if (warriorBClass.Equals("Warrior", StringComparison.OrdinalIgnoreCase))
                {
                    warriorB = new Warrior(warriorBName, warriorBHealth, warriorBDamage, warriorBBlock);
                }
                else if (warriorBClass.Equals("Mage", StringComparison.OrdinalIgnoreCase))
                {
                    warriorB = new MagicWarrior(warriorBName, warriorBHealth, warriorBDamage, warriorBBlock, 50);
                }


                Battle.StartFight(warriorA, warriorB);

            }

            string GetValidName(string warrior)
            {
                string name;
                do
                {
                    Console.WriteLine($"Enter {warrior}'s name:");
                    name = Console.ReadLine().Trim();
                } while (string.IsNullOrWhiteSpace(name));

                return name;
            }

            string GetValidClass(string warriorName, string[] validOptions)
            {
                string warriorClass;
                bool isValidWarriorOptions;

                do
                {
                    Console.WriteLine($"Enter {warriorName}'s class (Warrior/Mage):");
                    warriorClass = Console.ReadLine();
                    isValidWarriorOptions = validOptions.Contains(warriorClass, StringComparer.OrdinalIgnoreCase);

                    if (!isValidWarriorOptions)
                    {
                        Console.WriteLine("Invalid class entered. Please choose either 'Warrior' or 'Mage'.");
                    }
                } while (!isValidWarriorOptions);

                return warriorClass;
            }

            double GetValidDoubleInput(string message)
            {
                double value;
                bool isValidInput;

                do
                {
                    Console.WriteLine(message);
                    string input = Console.ReadLine();
                    isValidInput = double.TryParse(input, out value);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                } while (!isValidInput);

                return value;
            }

            GetWarriorInfo();

        }

    }

}