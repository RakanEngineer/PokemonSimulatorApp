namespace PokemonSimulatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon Simulator!");
            Console.WriteLine("---------------------------------");
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            flamethrower.Use(1);
        }
    }
}
