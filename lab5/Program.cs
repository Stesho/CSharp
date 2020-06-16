using System;

namespace lab5
{
    enum Formating : int
    {
        Short = 0,
        Standart = 1, 
        All = 2
    }

    abstract class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    abstract class Sportsmen : Person
    {
        public int Rank { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Sportsmen(string name, int age, int rank, int weight, int height) : base(name, age)
        {
            this.Rank = rank;
            this.Weight = weight;
            this.Height = height;
        }
    }

    class Master : Sportsmen
    {
        public string SportKind { get; set; }

        public Master(string name, int age, int rank, int weight, int height, string sportKind) : base(name, age, rank, weight, height)
        {
            this.SportKind = sportKind;
        }
        public void Print(int format)
        {
            switch (format)
            {
                case (int)Formating.All:
                    Console.WriteLine($"Name: {Name}\nAge: {Age}\nRank: {Rank}\nWeight: {Weight}\nHeight: {Height}\nKind of sport: {SportKind}\n");
                    break;
                case (int)Formating.Standart:
                    Console.WriteLine($"Name: {Name}\nAge: {Age}\nRank: {Rank}\nWeight: {Weight}\nHeight: {Height}\n");
                    break;
                case (int)Formating.Short:
                    Console.WriteLine($"Name: {Name}\nAge: {Age}\n");
                    break;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Master Athlete1 = new Master("Van Damn", 1, 2, 75, 177, "karate");
            Athlete1.Print(0);

            Master Athlete2 = new Master("Jackie Chan", 3, 4, 65, 174, "karate");
            Athlete2.Print(1);

            Master Athlete3 = new Master("DD", 5, 6, 75, 177, "GG");
            Athlete3.Print(2);

        }
    }
}