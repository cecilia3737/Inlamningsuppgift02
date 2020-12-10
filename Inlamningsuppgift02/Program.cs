using System;
using System.Collections.Generic;

namespace Inlamningsuppgift02
{
    class Member
    {
        private string name;
        private int age;
        private int height;
        private string home;
        private string birthplace;
        private int siblings;
        private string color;
        private string food;
        private string hobbies;
        private string motivation;

        public Member(string name, int age, int height, string home, string birthplace, int siblings, string color, string food, string hobbies, string motivation)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Home = home;
            this.Birthplace = birthplace;
            this.Siblings = siblings;
            this.Color = color;
            this.Food = food;
            this.Hobbies = hobbies;
            this.Motivation = motivation;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Height { get => height; set => height = value; }
        public string Home { get => home; set => home = value; }
        public string Birthplace { get => birthplace; set => birthplace = value; }
        public int Siblings { get => siblings; set => siblings = value; }
        public string Color { get => color; set => color = value; }
        public string Food { get => food; set => food = value; }
        public string Hobbies { get => hobbies; set => hobbies = value; }
        public string Motivation { get => motivation; set => motivation = value; }
    }

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
                    Console.WriteLine("---------------------------");
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
                Console.WriteLine("---------------------------");
                //Switch
                //Case 1 - MembersList();
                //Case 2 - MemberInfo();
                //Case 3 - RemoveMember();
                //Case 4 - Avsluta program
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
            Member Cecilia = new Member("Cecilia", 29, 163, "Norrköping", "Norrköping", 1, "Gul", "Risotto", "Spela The Sims", "Få arbeta kreativt");
            Member David = new Member("David", 32, 183, "Norrtälje", "Göteborg", 1, "Blå", "Tacos", "BJJ", "Problemlösning");
            Member Elin = new Member("Elin", 31, 170, "Knivsta", "Karlskoga", 2, "Röd", "Sushi", "Hästar", "Personlig utveckling");
            Member Ivo = new Member("Ivo", 42, 174, "Uppsala", "Split", 1, "Svart", "Scampi", "Fotografi", "Kreativitet");
            Member Jeremy = new Member("Jeremy", 19, 181, "Djurö", "Köln", 1, "Teal", "Älggryta", "Gaming", "Jobb");
            Member Johan = new Member("Johan", 34, 194, "Mariefred", "Mariefred", 2, "Blå", "Tacos", "Gaming", "Trygg framtid");
            Member Mostafa = new Member("Mostafa", 33, 174, "Stockholm", "Stockholm", 4, "Svart", "Oxfilé", "Träning", "Tycker om att koda och lösa problem");
            Member Oscar = new Member("Oscar", 26, 185, "Stockholm", "Stockholm", 1, "Blå", "Lasagne", "Fotboll", "Jobb");
            Member Rami = new Member("Rami", 0, 0, "Okänt", "Okänt", 0, "Okänt", "Okänt", "Okänt", "Okänt");
            Member Sanjin = new Member("Sanjin", 30, 179, "Norrköping", "Mostar", 2, "Blå", "Pizza", "Fotboll", "Jobb");

            bästkustenMembers.Add(Cecilia);
            bästkustenMembers.Add(David);
            bästkustenMembers.Add(Elin);
            bästkustenMembers.Add(Ivo);
            bästkustenMembers.Add(Jeremy);
            bästkustenMembers.Add(Johan);
            bästkustenMembers.Add(Mostafa);
            bästkustenMembers.Add(Oscar);
            bästkustenMembers.Add(Rami);
            bästkustenMembers.Add(Sanjin);
        }
        //-ShowMemberList--Visar lista på medlemmarnas namn i konsol
        static void ShowMembersList()
        {
            Console.WriteLine(" Bästkustens medlemmar: ");

            for (int i = 0; i < bästkustenMembers.Count; i++)
            {
                Console.WriteLine(" " + bästkustenMembers[i].Name);
            }

            Console.WriteLine("---------------------------");
        }

        //-MemberInfo--Frågar om en specifik medlem och tar fram information om denne
        static void MemberInfo()
        {
            Console.WriteLine(" Skriv namnet på medlemmen som du vill få ut info om: ");
            Console.Write(" Namn:");
            string choice = Console.ReadLine();

            for (int i = 0; i < bästkustenMembers.Count; i++)
            {
                if (choice == bästkustenMembers[i].Name)
                {
                    Console.WriteLine(" Ålder: " + bästkustenMembers[i].Age);
                    Console.WriteLine(" Längd: " + bästkustenMembers[i].Height);
                    Console.WriteLine(" Hemort: " + bästkustenMembers[i].Home);
                    Console.WriteLine(" Födelseort: " + bästkustenMembers[i].Birthplace);
                    Console.WriteLine(" Antal syskon: " + bästkustenMembers[i].Siblings);
                    Console.WriteLine(" Favoritfärg: " + bästkustenMembers[i].Color);
                    Console.WriteLine(" Favoritmat: " + bästkustenMembers[i].Food);
                    Console.WriteLine(" Hobby: " + bästkustenMembers[i].Hobbies);
                    Console.WriteLine(" Motivation till programmering: " + bästkustenMembers[i].Motivation);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("---------------------------");
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
            Console.WriteLine("---------------------------");
        }

        //-Quit--Avslutar programmet
        static void Quit()
        {
            Console.WriteLine(" Du valde att avsluta, tack och hej");
        }
    }
}
