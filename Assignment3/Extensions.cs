using System;
using System.Linq;
using System.Collections.Generic;


namespace Assignment03
{
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> collection){
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items){
            return items.SelectMany(item => item);
            
        }

        public static IEnumerable<int> GreaterThan42DivisibleBy7(this IEnumerable<int> items){

            return items.Where(item => item > 42 && item%7 == 0);
        }

        public static IEnumerable<int> LeapYear(this IEnumerable<int> items){

            return items.Where(item => DateTime.IsLeapYear(item));
        }
    }
}
