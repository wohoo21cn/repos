using System;
using static static_properties.Trivial;

namespace static_properties
{
    class Trivial
    {
        public static int MyValue { get; set; }
        public void PrintValue()
        {
            Console.WriteLine("Value from inside {0}",MyValue  );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init Value {0}",Trivial .MyValue    );
            Trivial.MyValue = 10;
            Console.WriteLine("Init Value {0}", Trivial.MyValue);

            MyValue = 20;
            Console.WriteLine($"new value: {MyValue} ");

            Console.ReadKey();
        }
    }
}
