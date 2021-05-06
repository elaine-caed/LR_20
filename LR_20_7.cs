using System;

namespace LR_20_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write(" Enter string: ");
            str = Console.ReadLine();
            int x = str.IndexOf("x");
            if(str.IndexOf("x")== -1)
            {
                Console.WriteLine("No letter x in the string");
            }
            if (str.IndexOf("x") != -1)
            {
                Console.WriteLine("Amount of letters before letter {0}: {1}", "x", x);
            }
            int w = str.IndexOf("w");
            if (str.IndexOf("w") == -1)
            {
                Console.WriteLine("No letter w in the string");
            }
            if (str.IndexOf("w") != -1)
            {
                Console.WriteLine("Amount of letters before letter w: {0}", w);
            }
            if (str.IndexOf("w") < str.IndexOf("z"))
            {
                Console.WriteLine("Letter w is before x");
            }
            else
            {
                Console.WriteLine("Letter x is before w");
            }
        }
    }
}
