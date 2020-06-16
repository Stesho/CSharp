using System;
using System.Text;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //Console.WriteLine($"length = {str.Length}");
            char[] word = new char[20];
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1, j = 0; ; i--, j++)
            {
                if (i == 0)
                {
                    word[j] = str[i];
                    for (int k = j; k >= 0; k--)
                    {
                        sb.Append(word[k]);
                    }
                    break;
                }
                if (str[i] == ' ')
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        sb.Append(word[k]);
                    }
                    sb.Append(" ");
                    i--;
                    j = 0;
                }
                word[j] = str[i];
            }
            Console.WriteLine(sb);
        }
    }
}
