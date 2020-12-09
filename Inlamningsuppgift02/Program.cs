using System;

namespace Inlamningsuppgift02
{
    //Class Member
    //private string name;
    //private int height;
    //private int age;
    //private string hobbies;
    //private string food;
    //private string color;
    //private string motivation;
    //private string home;
    //private string birthplace;
    //private int siblings;
    class Program
    {
        static void Main(string[] args)
        {

            Password();
            StartMenu();


        }

        //-Password-metod-
        static void Password()
        {
            Console.WriteLine("Välkommen, logga in för att se detaljer om gruppens deltagare.");
            bool run = true;

            do
            {

                Console.Write("Lösenord: ");
                string password = Console.ReadLine();

                if (password.ToLower() == "bästkusten")
                {
                    Console.WriteLine("Rätt lösenord!");
                    Console.WriteLine("---------------------------");
                    run = false;
                }

                else
                {
                    Console.WriteLine("Fel lösenord, försök igen!");
                }

            } while (run == true);
        }
        
        //-StartMenu-metod-Do While

        static void StartMenu() 
        {
            Console.WriteLine("a. Lista med alla deltagare");
            Console.WriteLine("b. Information om deltagare");
            Console.WriteLine("c. Ta bort deltagare");
            Console.WriteLine("d. Avsluta programmet");

            string userChoice = Console.ReadLine();
            Console.WriteLine("---------------------------");

        }

        //Switch
        //Case 1 - MembersList();
        //Case 2 - MemberInfo();
        //Case 3 - RemoveMember();
        //Case 4 - Avsluta program

        //-MemberList-metod-
        //Skapa lista av human
        //Gör en for each-loop som listar upp medlemar

        //-MemberInfo-metod-
        //Lägg till medlemsinfo i lista "Member"

        //-RemoveMember-metod-
        //Tar bort vald medlem från listan, använd en for-loop och be user om nummer från member-lista


    }
}
