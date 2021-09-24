using System;
using System.Collections.Generic;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWord("Hello World");
            printProduct(3, 2);
        }

        static void ReverseWord(string s){
            Action<string> word = (string str) => {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            };
            word(s);
        }

        static void printProduct(double x, double y)
        {
            Func<double, double, double> product = (double number1, double number2) => number1 * number2; 
            var result = product(x, y);
            Console.WriteLine(result);
        }

        
    }
}
