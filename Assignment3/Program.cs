using System;
using System.Collections.Generic;

namespace Assignment03
{


    public class Program
    {
        public static Func<String, String> ReverseWord = (string s) => {
                 char[] charArray = s.ToCharArray();
                 Array.Reverse(charArray);
                 return new string(charArray);
        };

        public static Func<double, double, double> Product = (x, y) => x * y; 

        public static Func<string, int, bool> NumericallyEqual = (s, i) => {
            int number;
            return Int32.TryParse(s, out number) ? Int32.Parse(s) == i : false;
        };

        static void Main(string[] args)
        {
            
        }
    }
}
