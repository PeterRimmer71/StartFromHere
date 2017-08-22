using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //test 2
            int a = 5; // integer variable
            PrintMessage(a);
            MyClass x = new MyClass(); // we need it
            ClassTwo xyz = new ClassTwo();  // change to the development branch
            Console.WriteLine("Second line");
            x.PrintBone();    //adding an extra comment to the develop branch while adding features on Feature-X branch!!!
            Console.WriteLine("Factorial of, {0} is, {1}",a,x.Factorial(a)); // display result
            xyz.PrintIt();    // comment added to the herewego branch
            Console.WriteLine("Random number was, {0}", xyz.Stuff());
            Steps(8);
            Console.ReadKey();
        }

        private static void PrintMessage(int a)
        {
            Console.WriteLine("Hello World, " + a); // print message to screen
        }

        public static void Steps(int x)
        {
            if (x <= 0)
                Console.WriteLine("$----$");
            else
            {
                for(int i=0; i<x; i++)
                {
                    for(int j=0; j<i; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
