using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._2
{
    class HelloWorld
    {
        public static void output(String[] args)
        {
            Console.WriteLine("Homework NO.2:");
            if (args.Length >= 2)
            {
                Console.WriteLine("Hello World! From {0} To {1}", args[0], args[1]);
                foreach (string i in args)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("Hello World! command line parameter does not meet the requirement!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld.output(args);
            Console.ReadLine();
        }
    }
}
