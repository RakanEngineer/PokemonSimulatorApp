using PokemonSimulatorApp.Species;

namespace PokemonSimulatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon Simulator!");
            Console.WriteLine(new string('-', 40));

            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);
            Attack fireBlast = new Attack("Fire Blast", ElementType.Fire, 15);

            Attack waterGun = new Attack("Water Gun", ElementType.Water, 10);
            Attack hydroPump = new Attack("Hydro Pump", ElementType.Water, 5);
            Attack bubbleBeam = new Attack("Bubble Beam", ElementType.Water, 7);

            Attack vineWhip = new Attack("Vine Whip", ElementType.Grass, 8);
            Attack solarBeam = new Attack("Solar Beam", ElementType.Grass, 4);
            Attack razorLeaf = new Attack("Razor Leaf", ElementType.Grass, 9);

            flamethrower.Use(1);
            waterGun.Use(1);
            vineWhip.Use(1);

            var charmander = new Charmander(1, new List<Attack> { flamethrower, ember, waterGun });
            var squirtle = new Squirtle(2, new List<Attack> { waterGun, hydroPump, bubbleBeam });
            var bulbasaur = new Bulbasaur(3, new List<Attack> { vineWhip, solarBeam, razorLeaf });

            //charmander.RaiseLevel();
            //charmander.RandomAttack();

            List<Pokemon> myTeam = new List<Pokemon> { charmander, squirtle, bulbasaur };

            foreach (var pokemon in myTeam)
            {
                try
                {
                    pokemon.RaiseLevel();
                    //pokemon.RandomAttack();
                    pokemon.Attack();

                    if (pokemon is IEvolvable evolvable)
                    {
                        evolvable.Evolve();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine(new string('-', 40));
                Console.WriteLine();
            }
        }
    }
}
