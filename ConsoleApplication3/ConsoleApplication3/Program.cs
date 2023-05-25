using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("plz enter num:");
            string number = Console.ReadLine();
            x = int.Parse(number);
            x *= 3;
            Console.WriteLine(x);
            Console.WriteLine("press any key exit...");
            Console.ReadKey();
        }
    }
}
