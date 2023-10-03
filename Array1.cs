internal class Program
{
    public static void Main(string[] args)
    {
        string[] cars = { "Ford", "Cadillac", "Audi", };
        Array.Sort(cars);
        foreach (string i in cars)
        {
            Console.WriteLine($"{i}");

        }
    }
}