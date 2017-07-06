using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            string str;
            do
            {
                int n = Convert.ToInt32(Console.ReadLine());
                s = s + n;
                str = Console.ReadLine();

            } while (str != "exit");

            Console.WriteLine(s);
        }
    }
}
