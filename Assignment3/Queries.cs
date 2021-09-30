using System.Collections.Generic;
using System.Linq;
using System;

namespace Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> ExtAllRowling()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(w => w.Creator == "J.K. Rowling").Select(w => w.Name).ToList();
        }

        public static int? ExtFirstSithLord()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(w => w.Name.Contains("Darth")).Select(w => w.Year).Min();
        }

        public static IEnumerable<(string, int?)> ExtUniqueHarryPotter()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(w => w.Medium.Equals("Harry Potter")).Select(w => (w.Name, w.Year)).Distinct().ToList();
        }

        public static IEnumerable<string> ExtReverseFiesta()
        {
            var wizards = Wizard.Wizards.Value;

            return (wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).Select(w => w.Name)).ToList();
        }

        public static IEnumerable<string> AllRowling()
        {
            var wizards = Wizard.Wizards.Value;

            var w1 =    (from w in wizards 
                        where w.Creator == "J.K. Rowling"
                        select w.Name).ToList();
            
            return w1;   
        }

        public static int? FirstSithLord()
        {
            var wizards = Wizard.Wizards.Value;

            var w2 = (from w in wizards
                    where w.Name.Contains("Darth")
                    select w.Year).Min();

            return w2;
        }

        public static IEnumerable<(string, int?)> UniqueHarryPotter()
        {
            var wizards = Wizard.Wizards.Value;

            var w3 = (from w in wizards
                    where w.Medium == "Harry Potter"
                    select (w.Name, w.Year)).ToList();
            
            return w3;
                    
        }

        public static IEnumerable<string> ReverseFiesta()
        {
            var wizards = Wizard.Wizards.Value;

            //return wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name);

            var w4 =    (from w in wizards
                        orderby w.Name descending
                        orderby w.Creator descending
                        group w by new {w.Creator, w.Name} into g
                        select g.Key.Name).ToList();
            
            return w4;

        }
    }
}
