using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Battle
    {
        // Start the fight
        // Warrior 1 attack warrior 2, warrior 2 is damaged and his health decreased
        // Get the attack result
        // Warrior 2 attack warrior 1, warrior 1 is damaged and his health decreased
        // Get the attack result

        // This is a utility class so it makes sense
        // to have just static methods

        // Receive both Warrior objects
        public static void StartFight(Warrior warrio01, Warrior warrior02)
        {
            // Loop giving each Warrior a chance to attack
            // and block each turn until 1 dies
            while (true)
            {
                if (GetAttackResult(warrio01, warrior02) == "Game Over!")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }


                if (GetAttackResult(warrior02, warrio01) == "Game Over!")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
            }
        }

        // get attack result, Accept 2 Warriors
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            // Calculate one Warriors attack and the others block
            double warriorAAttackAmount = warriorA.Attack();
            double warriorBBlockAmount = warriorB.Block();

            // Subtract block from attack
            double damageToWarriorB = warriorAAttackAmount - warriorBBlockAmount;

            // If there was damage subtract that from the health
            if (damageToWarriorB > 0)
            {
                warriorB.Health -= damageToWarriorB;
            }
            else damageToWarriorB = 0;

            // Print out info on who attacked who and for how much damage
            Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and deals {damageToWarriorB} damage.");

            // Provide output on the change to health
            Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);

            // Check if the warriors health fell below
            // zero and if so print a message and send
            // a response that will end the loop
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n", warriorB.Name, warriorA.Name);
                return "Game Over!";
            }
            else return "Fight Again!";
        }

    }
}
