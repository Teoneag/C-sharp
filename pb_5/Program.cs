using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            int divisor = 2;

            while (count < 2 && divisor <= n)
            {
                if (n % divisor == 0)
                {
                    sum += divisor;
                    count++;
                }

                divisor++;
            }

            Console.WriteLine(sum);

        }
    }
}