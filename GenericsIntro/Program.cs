using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");


        }
    }
}
