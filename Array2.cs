internal class Array2
{
    public static void Main(string[] args)
    {
        int[] numbers = { 12, 50, 72 };
        int summa = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            summa += numbers[i];
        }
        Console.WriteLine("summan av alla talen blir " + summa);
    }
}