using System;
using System.Collections.Generic;

namespace Assignment03
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReverseWord("Hello World");
            printProduct(3, 2);
        }

        public static string ReverseWord(string s){
            Func<string, string> word = (string str) => {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };
            return word(s);
        }

        public static double printProduct(double x, double y)
        {
            Func<double, double, double> product = (double number1, double number2) => number1 * number2; 
            var result = product(x, y);
            return result;
        }

        
    }
}
