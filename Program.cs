using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 1;
            int y = 0;
            int z = division(x, y);
        }

        public static int division(int x, int y)
        {
            return x/y;
        }
    }
}
