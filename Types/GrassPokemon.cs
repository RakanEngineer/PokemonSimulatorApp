using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulatorApp.Types
{
    public abstract class GrassPokemon : Pokemon
    {
        public GrassPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Grass, attacks)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Squirtle squirtle!");
        }
    }
}
