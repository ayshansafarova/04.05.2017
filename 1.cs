using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 0, s2 = 0;
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] < 0)
                {
                    s1 = s1 + a[i];

                }
                else
                {
                    s2 = s2 + a[i];
                }
            }

            Console.WriteLine("Menfi ededlerin cemi: " + s1);
            Console.WriteLine("Musbet ededlerin cemi: " + s2);
        }
    }
}
