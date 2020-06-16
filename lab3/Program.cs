using System;

namespace Lab3
{
    class Person
    {
        private string name;
        private int height;
        private string rank;
        public static string country;

        public Person() : this("No Info")
        {
        }
        public Person(string a) : this(a, 0, "No Info")
        {
        }
        public Person(string a, int b) : this(a, b, "No Info")
        {
        }
        public Person(string a, string c) : this(a, 0, c)
        {
        }
        public Person(int b, string c) : this("No Info", b, c)
        {
        }
        public Person(string name, int weight, string country)
        {
            this.name = name;
            this.height = weight;
            this.rank = country;
        }


        public void SetValue(string name, int weight, string country)
        {
            this.name = name;
            this.height = weight;
            this.rank = country;
        }
        public void SetCountry(int val)
        {
            switch (val)
            {
                case 1:
                    Person.country = "Germany";
                    break;
                case 2:
                    Person.country = "Russia";
                    break;
                case 3:
                    Person.country = "USA";
                    break;
                case 4:
                    Person.country = "UK";
                    break;
                case 5:
                    Person.country = "France";
                    break;
            }
        }

        public string GetName()
        {
            return name;
        }

        public int GetHeight()
        {
            return height;
        }

        public string GetRank()
        {
            return rank;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} \nHeight: {height} \nRank: {rank}");
        }

    }

    class Sportsman : Person
    {
        Person[] info;
        public Sportsman(int a)
        {
            info = new Person[a];
        }

        public Person this[int index]
        {
            get
            {
                return info[index];
            }
            set
            {
                info[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 5, val;
            Random rnd = new Random();
            Sportsman Athlete = new Sportsman(num);

            Athlete[0] = new Person("Alexey", 195, "Master");

            Athlete[1] = new Person("Ivan", 195, "No Info");

            Athlete[2] = new Person("Pavel", "Skilled");

            Athlete[3] = new Person(195, "Professional");

            Athlete[4] = new Person();
            Athlete[4].SetValue("Ilya", 170, "beginner");

            for(int i = 0; i < num; i++)
            {
                val = rnd.Next(1, 5);
                Athlete[i].SetCountry(val);

                Athlete[i].GetInfo();
                Console.WriteLine($"Country: {Person.country}\n");
            }
        }
    }
}