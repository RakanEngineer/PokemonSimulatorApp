using PokemonSimulatorApp.Species;

namespace PokemonSimulatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon Simulator!");
            Console.WriteLine("---------------------------------");

            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);

            Attack waterGun = new Attack("Water Gun", ElementType.Water, 10);
            Attack hydroPump = new Attack("Hydro Pump", ElementType.Water, 5);

            Attack vineWhip = new Attack("Vine Whip", ElementType.Grass, 8);
            Attack solarBeam = new Attack("Solar Beam", ElementType.Grass, 4);

            flamethrower.Use(1);
            waterGun.Use(1);
            vineWhip.Use(1);
            Console.WriteLine("---------------------------------");

            var charmander = new Charmander(5, new List<Attack> { flamethrower, ember,waterGun });
            charmander.RaiseLevel();
            charmander.RandomAttack();
        }
    }
}
