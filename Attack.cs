using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulatorApp
{
    internal class Attack
    {
        private string Name { get; set; }
        public ElementType Type { get; set; }
        private int BasePower { get; set; }

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }
        public void Use(int level)
        {
            int totalPower = BasePower + level;
            Console.WriteLine($"{Name} hit with a total power of {totalPower}");
        }
    }

}
