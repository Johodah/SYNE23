public class Program
{
    public static void Main(string[] args)
    {
        string[] djurarter = { "Björn", "Knubbsäl", "Elefant", "Gråvarg", "Isbjörn" };
        Console.WriteLine("I djurparken finns det bland annat: ");
        foreach (string d in djurarter)
        {
            Console.WriteLine(d);
        }

    }
    
}