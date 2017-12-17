using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // the name is comming from: Hello-> Properties -> Debug -> Command Line Arguments
            Console.WriteLine("Hello! " + args[0] +" this is "+DateTime.Now.DayOfWeek);
            Console.ReadLine();
        }
    }
}

