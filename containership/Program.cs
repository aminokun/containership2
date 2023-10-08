namespace containership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(2,3);
            Console.WriteLine(ship.ToString());

        }
    }
}