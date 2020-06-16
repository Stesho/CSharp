using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, m1, m2;
            string s;
            Console.WriteLine("Введите 2 числа в виде числителя и знаменателя");
            Console.WriteLine("Введите числитель 1ого числа");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числитель 2ого числа");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель 1ого числа");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель 2ого числа");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строковое представление числа");
            s = Console.ReadLine();

            var a = new Fraction(n1, m1);
            var b = new Fraction(n2, m2);
            var c = new Fraction(s);

            Console.WriteLine($"Сложение: {(a + b).ToString(2)}");
            Console.WriteLine($"Вычитание: {(a - c).ToString(1)}");
            Console.WriteLine($"Умножение: {(a * b).ToString(1)}");
            Console.WriteLine($"Деление: {(a / b).ToString(1)}");
            Console.WriteLine($"Сравнения:");
            if(a < b)
                Console.WriteLine($"{a.ToString(2)} < {b.ToString(2)}");
            else if (a > b)
                Console.WriteLine($"{a.ToString(2)} > {b.ToString(2)}");
            if (a <= b)
                Console.WriteLine($"{a.ToString(2)} <= {b.ToString(2)}");
            else if (a >= b)
                Console.WriteLine($"{a.ToString(2)} >= {b.ToString(2)}");
            if (a == b)
                Console.WriteLine($"{a.ToString(2)} == {b.ToString(2)}");
            else if (a != b)
                Console.WriteLine($"{a.ToString(2)} != {b.ToString(2)}");

            Console.WriteLine($"{(int)a}");
            Console.WriteLine($"{(double)b}");

            if (a.Equals(a))
                Console.WriteLine("a equals a");
            if (b.Equals(a))
                Console.WriteLine("b equals a");
        }
    }
}
