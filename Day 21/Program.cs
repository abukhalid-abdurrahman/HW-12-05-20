using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_21
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();

            Console.Read();
        }

        static void FirstTask()
        {
            string lineSeperator = new string('*', 25);
            Console.WriteLine("Task 1...");
            string oldStr = "hello";
            string newStr = new String(oldStr.Select(c => c == 'a' ? '1' : c)
                .Select(c => c == 'e' ? '2' : c)
                .Select(c => c == 'i' ? '3' : c)
                .Select(c => c == 'o' ? '4' : c)
                .Select(c => c == 'u' ? '5' : c).ToArray());
            Console.WriteLine(oldStr + " => " + newStr);
        }
    }
}
