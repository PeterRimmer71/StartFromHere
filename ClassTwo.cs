using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ClassTwo
    {
        private string NameTwo { get; set; }

        public void PrintIt() => Console.WriteLine("iT");

        public string Stuff()
        {
            string x = "SMALL";
            if (new Random().Next(0,10) > 4)
            {
                x = "BIG";
            }
            return x;
        }
    }
}
