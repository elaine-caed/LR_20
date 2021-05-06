using System;

namespace LR_20_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string str2 = "";
            Console.Write("Enter string: ");
            str = Console.ReadLine();
            var rplc = str.Replace(" ", "");
            for (int i = 0; i < rplc.Length; i++)
            {
                Console.Write($"{rplc[i]} ");
            }
        }
    }
}
