using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("hello" + name);
            Console.WriteLine("press any key exit...");
            Console.ReadKey();

        }
    }
}
