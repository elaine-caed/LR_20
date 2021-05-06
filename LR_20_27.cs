using System;

namespace LR_20_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str;
            int count;
            int count2 = 0;
            int a = 0;
            string s;
            Console.Write(" count = ");
            count = Int32.Parse(Console.ReadLine());
            str = new string[count];
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($" String {i}: ");
                str[i] = Console.ReadLine();
                for (int j = 0; j < str.Length; j++)
                {
                    s = str[j];
                    if (str >= '0' && str <= '9')
                    {
                        count2++;
                    }
                }
                Console.WriteLine(count2);
            }
        }
    }
}
