using Constructor;
using System;

namespace Constructor
{
   class myClass
    {
        readonly int firstVar;
        readonly double secondVar;

        public string userName;
        public int userIdNumber;

        private myClass()
        {
            firstVar = 20;
            secondVar = 30;

        }

        public myClass(string firstName):this()
        {
            userName = firstName;
            userIdNumber = -1;
        }

        public myClass(int idNumber) : this()
        {
            userName = "Anonymous";
            userIdNumber = idNumber;
        }
    }
    
    }
    class Program
    {
        static void Main(string[] args)
        {

        myClass mc = new myClass("Zhangsan");
        myClass mc2 = new myClass(2);
        Console.WriteLine($"myClass : {mc.userName },{mc.userIdNumber}");
        Console.WriteLine($"myClass : {mc2.userName },{mc2.userIdNumber}");
        Console.WriteLine($"myClass : {mc2.firstVar},{mc2.userIdNumber}");
        Console.ReadKey();


        }
    }

