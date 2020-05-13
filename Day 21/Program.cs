using System;
using System.Linq;

namespace Day_21
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();

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

            Console.WriteLine(lineSeperator);
        }
        static void SecondTask()
        {
            string lineSeperator = new string('*', 25);
            Console.WriteLine("Task 2...");

            string oldStr = "h3 th2r2";
            string newStr = new String(oldStr.Select(c => c == '1' ? 'a' : c)
                .Select(c => c == '2' ? 'e' : c)
                .Select(c => c == '3' ? 'i' : c)
                .Select(c => c == '4' ? 'o' : c)
                .Select(c => c == '5' ? 'u' : c).ToArray());
            Console.WriteLine(oldStr + " => " + newStr);

            Console.WriteLine(lineSeperator);
        }
        static void ThirdTask()
        {
            string lineSeperator = new string('*', 25);
            Console.WriteLine("Task 3...");

            string inputedStr = "gdfgdf234dg54gf*23oP42";
            string operatorStr = new String(inputedStr.Where(x => Char.IsPunctuation(x)).ToArray());
            int A = int.Parse(new String(inputedStr.Where(x => Char.IsPunctuation(x) || Char.IsNumber(x)).ToArray()).Split(Convert.ToChar(operatorStr))[0]);
            int B = int.Parse(new String(inputedStr.Where(x => Char.IsPunctuation(x) || Char.IsNumber(x)).ToArray()).Split(Convert.ToChar(operatorStr))[1]);
            int results = operatorStr == "*" ? A * B : operatorStr == "/" ? A / B : operatorStr == "-" ? A - B : operatorStr == "+" ? 0 : A + B;
            Console.WriteLine($"{inputedStr} => {A} {operatorStr} {B} = {results}"); 
            Console.WriteLine(lineSeperator);
        }
        static void FourthTask()
        {
            string lineSeperator = new string('*', 25);
            Console.WriteLine("Task 2...");

            string textStr = "textCamel";
            var editedText = textStr.Select(ch => ch.ToString()).Select(ch => char.IsUpper(char.Parse(ch)) ? " " + ch : ch);
            Console.Write($"{textStr} => ");
            foreach (var item in editedText)
            {
                Console.Write(item);
            }

            Console.WriteLine("\n" + lineSeperator);
        }
    }
}
