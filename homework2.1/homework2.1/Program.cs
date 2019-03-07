using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_one
{
    class HelloWorld
    {
        public void output(String[] args)
        {
            Console.WriteLine("Homework NO.1:");
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
            HelloWorld myHello = new HelloWorld();
            myHello.output(args);
            Console.ReadLine();
        }
    }
}

