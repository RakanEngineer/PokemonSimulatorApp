using PokemonSimulatorApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonSimulatorApp.Species
{
    public class Charmander : FirePokemon, IEvolvable
    {
        public Charmander(int level, List<Attack> attacks)
            : base("Charmander", level, attacks)
        {
        }

        public void Evolve()
        {
            Console.WriteLine();
            Console.WriteLine("----------Evolution----------");
            string oldName = Name;
            Name = "Charmeleon";
            Level += 10;

            Console.WriteLine($"{oldName} is evolving... Now it is a {Name} and its level is {Level}");
        }
    }
}
