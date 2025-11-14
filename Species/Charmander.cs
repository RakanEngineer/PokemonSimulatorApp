using PokemonSimulatorApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulatorApp.Species
{
    public class Charmander : FirePokemon
    {
        public Charmander(int level, List<Attack> attacks)
            : base("Charmander", level, attacks)
        {
        }
    }
}
