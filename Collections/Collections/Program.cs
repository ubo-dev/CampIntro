using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("a");
            names.Add("b");
            names.Add("c");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            names.Add("f");
            Console.WriteLine(names[3]);
            Console.WriteLine(names[0]);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
