using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulatorApp
{
    public class Attack
    {
        public string Name { get; set; }
        public ElementType Type { get; set; }
        internal int BasePower { get; set; }

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }
        public virtual void Use(int level)
        {
            int totalPower = BasePower + level;
            Console.WriteLine($"{Name} hit with a total power of {totalPower}");
        }
    }

}
