using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - De kleine Zeemeermin");
            Console.WriteLine("\t2 - Scarface");
            Console.WriteLine("\t3 - Zwartlicht");
            Console.WriteLine("\t4 - Documentaire, Blood Diamond");
            Console.Write("Your option? ");

            // Use a switch statement to do the choosing.
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($" Beschikbaar op; \n\n \t11 - aanstaande 28 maart \n \t12 - aanstaande 3 april \n \t13 - aanstaande 11 april \n ");
                    break;
                case "2":
                    Console.WriteLine($" Beschikbaar op; \n\n \t14 - 19 maart \n \t15 - 2 april \n \t16 - 8 april \n  ");
                    break;
                case "3":
                    Console.WriteLine($" Beschikbaar op; \n\n \t17 - 16 maart \n \t18 - 1 april \n \t19 - 6 april \n  ");
                    break;
                case "4":
                    Console.WriteLine($" Beschikbaar op; \n\n \t20 - 26 maart \n \t21 - 8 april \n \t22 - 11 april \n  ");
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Cinema console app...");
            Console.ReadKey();
        }
    }
}