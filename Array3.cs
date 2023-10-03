public class Program
{
    public static void Main(string[] args)
    {
        string[] filmtitlar = { "Sagan om Ringen", "Star Wars", "Interstellar", "Howl's moving castle", "Your name" };
        Array.Sort(filmtitlar);
        for (int i = 0; i < filmtitlar.Length;)
        {
            Console.WriteLine(filmtitlar[i++]);
        }
    }
    
}