using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = new Reader();

            int a = u.Read<int>();           
            Console.WriteLine($"{a}");

            double v = u.Read<double>();
            Console.WriteLine($"{v}");


            Console.ReadLine();
        }
    }
}
