using System;

namespace Lab2._1
{
    class Program
    {
        static void NumCount(int[] x, char[] str)
        {
            for (int i = 0; i < 10; i++)
                x[i] = 0;
            for (int i = 0; i < str.Length; i++)
                for (int k = 0; k < 10; k++)
                    if (str[i] == k+48)
                        x[k]++;
            for (int i = 0; i < 10; i++)
                if (x[i] > 0)
                    Console.WriteLine($"'{i}' - {x[i]}");
        }
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            string date1 = date.ToString("F");
            char[] str = date1.ToCharArray();
            int[] x = new int[10];//индекс - число, значение - кол-во чисел
            Console.WriteLine(date1);
            NumCount(x, str);
            date1 = date.ToString();
            str = date1.ToCharArray();
            Console.WriteLine(date1);
            NumCount(x, str);
        }
    }
}
