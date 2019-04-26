using System;

namespace DesignPatterns_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context test = new Context();

            Console.WriteLine(test.GetString());
            Console.WriteLine(test.GetString());
            Console.WriteLine(test.GetNumber());
            Console.WriteLine(test.GetNumber());

            Console.ReadKey();
        }
    }
}
