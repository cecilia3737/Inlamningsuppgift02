using System;
using System.Collections.Generic;

namespace Inlamningsuppgift02
{
    class Program
    {
        static List<Member> bästkustenMembers = new List<Member>();

        static void Main(string[] args)
        {
            Password();
            MembersList();
            StartMenu();
        }

        //-Password--Ber användare om lösenord vid start
        static void Password()
        {
            Console.WriteLine(" Välkommen, logga in för att se detaljer om gruppens deltagare.");
            bool run = true;
            do
            {
                Console.Write(" Lösenord: ");
                string password = Console.ReadLine();

                if (password.ToLower() == "bästkusten")
                {
                    Console.WriteLine(" Rätt lösenord!");
                    Line();
                    run = false;
                }
                else
                {
                    Console.WriteLine(" Fel lösenord, försök igen!");
                }

            } while (run == true);
        }

        //-StartMenu--Navigerar i programmet och ber användare om olika val
        static void StartMenu()
        {
            bool run = true;
            do
            {
                Console.WriteLine(" a. Lista med alla deltagare");
                Console.WriteLine(" b. Information om deltagare");
                Console.WriteLine(" c. Ta bort deltagare");
                Console.WriteLine(" d. Avsluta programmet");

                string userChoice = Console.ReadLine();
                Line();

                switch (userChoice)
                {
                    case "a":
                        ShowMembersList();
                        break;

                    case "b":
                        MemberInfo();
                        break;

                    case "c":
                        RemoveMember();
                        break;

                    case "d":
                        Quit();
                        run = false;
                        break;
                }
            } while (run);
        }
        //-MemberList--Innehåller information om varje medlem
        static void MembersList()
        {
            bästkustenMembers.Add(new Member("Cecilia", 29, 163, "Norrköping", "Norrköping", 1, "Gul", "Risotto", "Spela The Sims", "Få arbeta kreativt"));
            bästkustenMembers.Add(new Member("David", 32, 183, "Norrtälje", "Göteborg", 1, "Blå", "Tacos", "BJJ", "Problemlösning"));
            bästkustenMembers.Add(new Member("Elin", 31, 170, "Knivsta", "Karlskoga", 2, "Röd", "Sushi", "Hästar", "Personlig utveckling"));
            bästkustenMembers.Add(new Member("Ivo", 42, 174, "Uppsala", "Split", 1, "Svart", "Scampi", "Fotografi", "Kreativitet"));
            bästkustenMembers.Add(new Member("Jeremy", 19, 181, "Djurö", "Köln", 1, "Teal", "Älggryta", "Gaming", "Jobb"));
            bästkustenMembers.Add(new Member("Johan", 34, 194, "Mariefred", "Mariefred", 2, "Blå", "Tacos", "Gaming", "Trygg framtid"));
            bästkustenMembers.Add(new Member("Mostafa", 33, 174, "Stockholm", "Stockholm", 4, "Svart", "Oxfilé", "Träning", "Tycker om att koda och lösa problem"));
            bästkustenMembers.Add(new Member("Oscar", 26, 185, "Stockholm", "Stockholm", 1, "Blå", "Lasagne", "Fotboll", "Jobb"));
            bästkustenMembers.Add(new Member("Rami", 0, 0, "Okänt", "Okänt", 0, "Okänt", "Okänt", "Okänt", "Okänt"));
            bästkustenMembers.Add(new Member("Sanjin", 30, 179, "Norrköping", "Mostar", 2, "Blå", "Pizza", "Fotboll", "Jobb"));
        }

        //-ShowMemberList--Visar lista på medlemmarnas namn i konsol
        static void ShowMembersList()
        {
            Console.WriteLine(" Bästkustens medlemmar: ");
            for (int i = 0; i < bästkustenMembers.Count; i++)
            {
                Console.WriteLine(" " + bästkustenMembers[i].Name);
            }
            Line();
        }

        //-MemberInfo--Frågar om en specifik medlem och tar fram information om denne
        static void MemberInfo()
        {
            Console.WriteLine(" Skriv namnet på medlemmen som du vill få ut info om: ");
            Console.Write(" Namn: ");
            string choice = Console.ReadLine();

            for (int i = 0; i < bästkustenMembers.Count; i++)
            {
                if (choice == bästkustenMembers[i].Name)
                {
                    Console.WriteLine($" Ålder: {bästkustenMembers[i].Age}");
                    Console.WriteLine($" Längd: {bästkustenMembers[i].Height}");
                    Console.WriteLine($" Hemort: {bästkustenMembers[i].Home}");
                    Console.WriteLine($" Födelseort: {bästkustenMembers[i].Birthplace}");
                    Console.WriteLine($" Antal syskon: {bästkustenMembers[i].Siblings}");
                    Console.WriteLine($" Favoritfärg: {bästkustenMembers[i].Color}");
                    Console.WriteLine($" Favoritmat: {bästkustenMembers[i].Food}");
                    Console.WriteLine($" Hobby: {bästkustenMembers[i].Hobbies}");
                    Console.WriteLine($" Motivation till programmering: {bästkustenMembers[i].Motivation}");
                }
                else
                {
                    continue;
                }
            }
            Line();
        }

        //-RemoveMember--Tar bort medlem från lista
        static void RemoveMember()
        {
            Console.WriteLine(" Skriv namnet på den medlem som ska tas bort:");
            Console.Write(" Namn:");
            string choice = Console.ReadLine();

            for (int i = 0; i < bästkustenMembers.Count; i++)
            {
                if (choice == bästkustenMembers[i].Name)
                {
                    bästkustenMembers.RemoveAt(i);
                    Console.WriteLine(" Du har nu tagit bort medlemmen från gruppen");
                }
                else
                {
                    continue;
                }
            }
            Line();
        }

        //-Quit--Avslutar programmet
        static void Quit()
        {
            Console.WriteLine(" Du valde att avsluta, tack och hej");
        }

        static void Line()
        {
            Console.WriteLine("---------------------------");
        }
    }
}
