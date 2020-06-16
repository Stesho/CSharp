using System;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Contains("."))
            {
                int num = 0, i = str.IndexOf(".") - 1;
                if (Char.IsLetter(str[0]))
                {
                    for (int j = 0; Char.IsDigit(str[i]); j++, i--)
                    {
                        num += (str[i] - 48) * Convert.ToInt32(Math.Pow(10, j));
                    }
                }
                else
                {
                    for (int j = 0; i >= 0; j++, i--)
                    {
                        num += (str[i] - 48) * Convert.ToInt32(Math.Pow(10, j));
                    }
                }
                Console.WriteLine($"\nnum = {num}");
            }
            else
                Console.WriteLine("Error");
        }
    }
}
