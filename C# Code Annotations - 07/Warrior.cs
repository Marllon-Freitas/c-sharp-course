using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Warrior
    {
        // Define the Warriors properties
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Always create a single Random instance and reuse
        // it or you will get the same value over and over
        Random random = new Random();

        // Constructor initializes the warrior
        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // Generate a random attack value from 1 o the warriors maximum attack value
        public double Attack()
        {
            return random.Next(1, (int)AttackMax);
        }

        // Generate a random block value from 1 to the warriors maximum block
        public virtual double Block()
        {
            return random.Next(1, (int)BlockMax);
        }
    }
}
