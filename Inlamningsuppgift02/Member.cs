using System;
using System.Collections.Generic;
using System.Text;

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
            Name = name;
            Age = age;
            Height = height;
            Home = home;
            Birthplace = birthplace;
            Siblings = siblings;
            Color = color;
            Food = food;
            Hobbies = hobbies;
            Motivation = motivation;
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
}
