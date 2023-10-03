public class Program
{
    public static void Main(string[] args)
    {
        string[,] böcker = 
        { 
            {"Sagan om ringen", "American Psycho", "One Piece Volume 1" }, 
            {"200kr", "150kr", "350kr"} 
        };

        int Bok = böcker.GetLength(1);
        
        for (int i = 0; i < Bok; i++)
        {
            string bokTitel = böcker[0,i];
            string pris = böcker[1, i];
            Console.WriteLine($"Bok: {bokTitel}, Pris: {pris}");
        }

    }
}

//tvådimensionell array med boktitel och pris för 3 böcker
//använd en for-loop