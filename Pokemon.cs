using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonSimulatorApp
{
    public abstract class Pokemon
    {
        private string name;
        private int level;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 15)
                    throw new ArgumentException("Name must be between 2 and 15 characters.");
                name = value;
            }
        }
        public int Level
        {
            get => level;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Level must be at least 1.");
                level = value;
            }
        }
        public ElementType Type { get; set; }
        public List<Attack> Attacks { get; private set; }

        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;

            if (attacks == null || attacks.Count == 0)
                throw new ArgumentException("A Pokemon must have at least one attack");

            Attacks = attacks;
        }
        public void RandomAttack()
        {
            Random rand = new Random();
            int attackIndex = rand.Next(Attacks.Count);
            var attack = Attacks[attackIndex];
            Console.WriteLine($"Pokemon: {Name} uses {attack.Type} attack");
            attack.Use(Level);
        }
        public void Attack()
        {
            Console.WriteLine($"{Name}, choose an attack:");

            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].Name} ({Attacks[i].Type})");
            }

            Console.Write("Enter attack number: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) ||
                choice < 1 || choice > Attacks.Count)
            {
                throw new ArgumentException("Invalid attack choice.");
            }

            Attack selected = Attacks[choice - 1];

            Console.WriteLine($"{Name} uses:");
            selected.Use(Level);
        }
        public void RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} has leveled up to level {Level}!");
        }
    }
}
