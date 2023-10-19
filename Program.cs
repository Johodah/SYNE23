class Program
{
    static string EncryptMessage(string message, int shiftValue) //den här metoden kodar ett skrivet meddelande. Både denna och Decrypt kallar på process för att göra om ett meddelande.
    {
        return Process(message, shiftValue, true);

    }
    static string DecryptMessage(string message, int shiftValue)  //den här metoden avkodar ett redan kodat meddelande. string = meddelandet och int = hur många platser den ska skiftas.
    {
        return Process(message, shiftValue, false);
    }
    static string Process(string message, int shiftValue, bool encrypt) //Här sker magin, den var svårast att få ihop och jag fick lära mig offset
                                                                        //och hur man försäkrar sig om stor/liten bokstav. shiftValue förflyttar texten det antal steg man skriver. 
                                                                        // aa + shiftValue 2 = cc och likadant tillbaka med decoder. Maximalt nummer man kan skriva är då antalet bokstäver (26) som finns i alfabetet.
                                                                        
    {
        char[] result = message.ToCharArray();                          //Här omvandlas stringen till en array av chars.
        for (int i = 0; i < result.Length; i++)
        {
            char c = result[i];

            if (char.IsLetter(c))                                       //är char en bokstav? Om inte, t.ex en siffra, låter den vara densamma.
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';              //kollar om bokstav är stor eller liten.

                if (encrypt)
                {
                    result[i] = (char)(((c - offset + shiftValue) % 26) + offset);  //Enkrypteringsprocessen sker här med att först kolla char (c) för varje bokstav i meddelandet
                                                                                    //och med offset kollas om det är stor/liten bokstav.
                                                                                    //shiftValue flyttar karaktären med ett visst antal steg som skrivet ovan.
                                                                                    //Hela uträkningen flyttar en karaktär till sin nya plats. a + 2 = c osv
                                                                                    //med decrypt gör den samma sak fast omvänt. c - 2 = a elr C - 2 = A
                                                                                    //Resultat sparas sedan i result[i] \n

                }
                else
                {
                    result[i] = (char)(((c - offset - shiftValue + 26) % 26) + offset);  //här sker samma som ovan fast omvänt (decrypt).
                }
            }
        }
        return new string(result);
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the secret coder system, comrade. \n" +
                "Choose a operation: 1. Encrypt. 2. Decrypt. 3. Exit program. ");
            try
            {
                //använder en try-catch runt programmet för att fånga ev. icke-nummer svar och felaktigheter.

                int operation = int.Parse(Console.ReadLine());

                if (operation == 3) //avslutar programmet.
                {
                    Console.WriteLine("Farewell Comrade, program exited.");
                    break;
                }

                if (operation != 1 && operation != 2) //Om man skriver in något annat än valen 1,2 eller 3.
                {
                    Console.WriteLine("That's an invalid input. Please try again");
                    continue;
                }

                Console.WriteLine("Okay Comrade, please enter message: ");  //dem här två tar in meddelande och shift-värdet.
                string message = Console.ReadLine();

                Console.WriteLine("Okay, now enter the shift value (a number): ");
                int shiftValue = int.Parse(Console.ReadLine());

                string result = (operation == 1) ? EncryptMessage(message, shiftValue) : DecryptMessage(message, shiftValue); //Här kollas det om svaret är 1. \n
                                                                                                                //Frågetecknet gör att om det inte är op 1, kör nästa (decrypt). Kallades ternary operator.

                if (operation == 1) //om valet var 1, gör enkrypteringen. 2 gör dekryptering.
                {
                    Console.WriteLine("Encrypted message follows: ");
                }
                else
                {
                    Console.WriteLine("Decrypted message follows: ");
                }

                Console.WriteLine(result); //skriv ut resultatet.
            }
            catch (FormatException) //fångar upp felaktigheter i inputen. Liknar den ovan men gäller för alla bokstäver också.
            {
                Console.WriteLine("Invalid input. Try again and write a valid number: 1, 2 or 3");
            }
        }
    }
}

//Caesar lät roligast att prova på fastän den såg mer skrämmande ut än vad det var tillslut. Men när man förstod själva 
//uträkningen eller shiftningen "result[i] = (char)(((c - offset + shiftValue) % 26) + offset);" och vad det innebar
// så gick det relativt smidigt att knåpa ihop det hela. Självklart blev det att googla en del för att förstå men överlag en bra utmaning.