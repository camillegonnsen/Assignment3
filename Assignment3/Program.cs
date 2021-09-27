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

        static void Main(string[] args)
        {
        }
    }
}
