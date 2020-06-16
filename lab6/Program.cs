using System;

namespace ConsoleApplication1
{
    /*interface IComparable<T>
    {
        public int CompareTo(object obj);
    }*/
    class Person
    {
        public string Name { set; get; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Person(string Name, int Height, int Weight)
        {
            this.Name = Name;
            this.Height = Height;
            this.Weight = Weight;
        }
        public virtual void OutputInfo()
        {
            Console.WriteLine($"Name: {Name}\tHeight: {Height}\tWeight: {Weight}");
        }
    }
    class Sportsman : Person
    {
        public string SportKind { get; set; }
        public Sportsman(string SportKind, string Name, int Height, int Weight) : base(Name, Height, Weight)
        {
            this.SportKind = SportKind;
        }
        public override void OutputInfo()
        {
            Console.WriteLine($"Name: {Name}\tHeight: {Height}\tWeight: {Weight}\t SportKind: {SportKind}");
        }
    }
    class Master : Sportsman, IComparable<Master>
    {
        public int Rating { get; set; }

        public Master(int Rating, string SportKind, string Name, int Height, int Weight) : base(SportKind, Name, Height, Weight)
        {
            this.Rating = Rating;
        }

        public int CompareTo(Master obj)
        {
            if (this.Rating > ((Master)obj).Rating)
                return 1;
            if (this.Rating < ((Master)obj).Rating)
                return -1;
            else
                return 0;
        }

        public override void OutputInfo()
        {
            Console.WriteLine($"Name: {Name}\tHeight: {Height}\tWeight: {Weight}\tSportKind: {SportKind}\tRating: {Rating}");
        }
    }

    class Program
    {
        static void Main()
        {
            Master[] Athlete = new Master[5];

            Athlete[0] = new Master(100, "karate", "Ivan", 177, 75);
            Athlete[1] = new Master(75, "boxing", "Vasiliy", 174, 65);
            Athlete[2] = new Master(200, "boxing", "Alexey", 177, 75);
            Athlete[3] = new Master(150, "muay-tai", "Buakaw", 175, 70);
            Athlete[4] = new Master(190, "mma  ", "Tony", 178, 72);

            for (int i = 0; i < 5; i++)
            {
                Athlete[i].OutputInfo();
            }

            Console.WriteLine("\nСортировка по рейтингу:");

            Array.Sort(Athlete);

            for (int i = 0; i < 5; i++)
            {
                Athlete[i].OutputInfo();
            }

            Console.ReadLine();
        }
    }
}
