using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 1000; x++)
            {
                Console.WriteLine("Hello World " + x.ToString());
            }
            Console.ReadLine();
        }
    }
}
