using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MyClass
    {
        public string Name { get; set; }

        public void PrintBone()
        {
            Console.WriteLine("$==$");
        }

        public int Factorial(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a - 1);
            }
        }
    }
}
