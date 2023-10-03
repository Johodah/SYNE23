public class Program
{
    public static void Main(string[] args)
    {
        string[] contactDetails = { "Johnny", "Dahle", "Kråkan 12", "073-nej", "johnny.dahle@minmailärprivat.swe" };
        Console.WriteLine("Mina kontaktuppgifter är: ");

        Console.WriteLine(contactDetails[0]);
        Console.WriteLine(contactDetails[1]);
        Console.WriteLine(contactDetails[2]);
        Console.WriteLine(contactDetails[3]);
        Console.WriteLine(contactDetails[4]);

    }

    //contactDetails[5] går inte då det inte finns flera minnesplatser, plats 1 är 0.//

}