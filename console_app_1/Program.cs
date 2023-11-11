using System;
using System.Collections.Specialized;

namespace Pb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = Convert.ToInt32(Console.ReadLine());
            long sum = 0;
            string s;
            long x;
            while (n > 0)
            {
                s = Console.ReadLine();
                n -= s.Trim().Split(' ').Length;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] <= (int)'9' && s[i] >= (int)'0')
                    {
                        x = (int)(s[i]) - (int)('0');
                        sum += x * x * x;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}