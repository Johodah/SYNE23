class Program
{

    enum veckodagar
    {
        Måndag,
        Tisdag,
        Onsdag,
        Torsdag,
        Fredag,
        Lördag,
        Söndag
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Ange ett tal");
        string number = Console.ReadLine();
        Console.WriteLine("du skrev: " + number);
        int y = int.Parse(number);
        Console.WriteLine("Kvadraten av " + y + " blir ");
        Console.WriteLine(y * y);
        //Uppgift 1

        Console.WriteLine("Ange ett tal med decimaler");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("du skrev in " + x);
        Console.WriteLine("Kvadratroten av " + x + " är " + Math.Sqrt(x));

        //Uppgift 2

        Console.WriteLine("Hej! Vad heter du?");
        string name = Console.ReadLine();
        Console.WriteLine("Hallå " + name + " och välkommen till SYS");

        //Uppgift 3

        bool success = true;
        Console.WriteLine("Write True or False");
        success = bool.Parse(Console.ReadLine());
        Console.WriteLine("You wrote " + success);

        //Uppgift 4

        Console.WriteLine("Skriv en bokstav eller ett tecken");
        char tecken = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(tecken);
        byte ascii = Convert.ToByte(tecken);
        Console.WriteLine(ascii);
        //Uppgift 5

        string dateString = "";
        Console.Write("Skriv in ett datum i ordningen DD/MM/YYYY: ");
        dateString = Console.ReadLine();
        DateTime date = new DateTime();
        date = DateTime.Parse(dateString);
        Console.WriteLine("Du uppgav " + date.ToString(" dd/MM/YYYY"));
        //Uppgift 6, årtalet funkar inte? TINTIN: När du kallar på ToString för ett DateTime objekt så är det viktigt med stora bokstäver, så du ska ist för "dd/MM/YYYY" ha "dd/MM/yyyy" :-)

        Console.WriteLine("Säg en veckodag");
        string UserInput = Console.ReadLine();

        veckodagar veckodagar;
        if (Enum.TryParse(UserInput, true, out veckodagar));
        {
            int numericvalue = (int)veckodagar;
            Console.WriteLine($"{UserInput} corresponds to the numeric value: {numericvalue}");
        
        }

    }
}
