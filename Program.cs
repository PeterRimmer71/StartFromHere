﻿using System;
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
            int a = 10; // integer variable
            PrintMessage(a);
            MyClass x = new MyClass(); // we need it
            ClassTwo xyz = new ClassTwo();
            Console.WriteLine("Second line");
            x.printBone();    //adding an extra comment to the develop branch while adding features on Feature-X branch!!!
            xyz.PrintIt();
        }

        private static void PrintMessage(int a)
        {
            Console.WriteLine("Hello World, " + a); // print message to screen
        }
    }
}
