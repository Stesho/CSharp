using System;
using System.Collections.Specialized;

namespace ConsoleApplication1
{

    class Person
    {
        public delegate void MassIndex();
        public delegate void MessageHandler(string message);
        public event MessageHandler Notify;
        public delegate double IndexReverse(int h, int w);
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

        public void A()
        {
            this.Notify += ecomessage;
            MassIndex mass;
            if (Height == 0)
                mass = ThrowEx;
            else
                mass = Count;
            mass();
            IndexReverse i = (h, w) =>  (double)(Math.Pow((double)Height / 100, 2) / Weight); ;
            Console.WriteLine("Inverse Index");
            Console.WriteLine(i(Height, Weight));
        }

        public void ThrowEx()
        {
            Notify?.Invoke("Exception");
            //throw new Exception("Нельзя делить на ноль");
        }

        public void Count()
        {
            MessageHandler handler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };
            double x = (double)(Weight / Math.Pow((double)Height/100, 2));
            handler($"Index = {x}");
            Notify?.Invoke($"Index = {Weight / Math.Pow(Height / 100, 2)}");
        }

        public static void ecomessage(string message)
        {
            if (message == "Exception")
                throw new Exception("Рост не может быть равен нулю");
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
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
        delegate void MessageHandler(string message);

        static void Main()
        {
            Master[] Athlete = new Master[5];

            Athlete[0] = new Master(100, "karate", "Ivan", 170, 65);
            Athlete[1] = new Master(75, "boxing", "Vasiliy", 174, 65);
            Athlete[2] = new Master(200, "boxing", "Alexey", 177, 75);
            Athlete[3] = new Master(150, "muay-tai", "Buakaw", 175, 70);
            Athlete[4] = new Master(190, "mma  ", "Tony", 178, 72);

            for (int i = 0; i < 5; i++)
            {
                Athlete[i].OutputInfo();
            }

            try
            {
                Athlete[0].A();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
