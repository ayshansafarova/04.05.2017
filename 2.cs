using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            Console.WriteLine("Neche sayda eded daxil edeceksiz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] % 2 != 0)
                {
                    count++;

                }
            }

            Console.WriteLine("Tek ededlerin sayi bu qederdir: " + count);

        }
    }
}
