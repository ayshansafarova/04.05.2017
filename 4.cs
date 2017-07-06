using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gedeceyiniz yerin koordinatlarinin daxil edin: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hal-hazirki yerinizin koordinatlarini daxil edin: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double distance, mebleg;
            distance = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
            mebleg = Convert.ToInt32(distance / 3);
            Console.WriteLine(mebleg+" manat taksiye vermelisiniz");

        }
    }
}
