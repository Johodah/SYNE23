class Program
{
    //Grupp-15
    //Johnny Dahle
    //Leo Bengtsson

    static bool isValidPNR(String Number)
    {
        if (Number.Length != 10)
        {
            Console.WriteLine("Din input är inte 10 siffror, försök igen");
            return false; 
        }

        int[] personnummer = new int[10];
        int[] multip = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

        for (int i = 0; i < 10; i++)                                        //den här for-loopen upprepar varje i mellan 0-9.
        {
            if (!int.TryParse(Number[i].ToString(), out personnummer[i])) //här sker konvertering till int och försöker spara det i personnummer
            {
                Console.WriteLine("Något blev fel där, försök igen. ");  //Skrivs något fel sker felmeddelande
                return false;
            }
        }

        int total = 0;                                         //här sparas uppgifterna i en egen variabel

        for (int i = 0; i < personnummer.Length; i++)         //Den här for-loopen itererar igenom alla siffror i personnummer arrayen och multiplicerar det med den motsvarande siffran i multip-arrayen som sedan sparas i resultat variabeln.
                                                              //Sen kollar den om resultatet av multiplikationen är lika eller större än 10.
        {
            int result = personnummer[i] * multip[i];

            if (result >= 10)
            {
                while (result > 0)           ///Är den det går den in i while-loopen för att använda modulus och separera sifforna och addera dem 2 som
                {
                    total += result % 10;
                    result /= 10;
                }
            }

            else
            {
                total += result;            //sedan skickar in resultatet i totalen om den är mellan 0-9.
            }
        }

        return total % 10 == 0;             //här kollas det om totalen kan delas med 10. Om ja är den giltig.

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett 10-siffrigt personnummer utan mellanslag: ");
        string input = Console.ReadLine();

        if (input.Length != 10)
        {
            Console.WriteLine("Du skrev in för få eller för många siffror, prova igen");

        }

        else
        {
            if (isValidPNR(input))
            {
                Console.WriteLine("Det är ett riktigt personnummer, hurra!");
            }
            else
            {
                Console.WriteLine("Det är ett ogiligt personnummer, synd");
            }
        }

    }
}
