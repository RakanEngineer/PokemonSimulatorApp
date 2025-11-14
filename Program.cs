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
        }
    }
}
