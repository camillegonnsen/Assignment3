using System.Collections.Generic;
using System.Linq;

namespace Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> ExtAllRowling()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(w => w.Creator == "J.K. Rowling").Select(w => w.Name);
        }

        public static Wizard ExtFirstSithLord()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).First();
        }

        public static IEnumerable<(string, int?)> ExtUniqueHarryPotter()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.Where(w => w.Medium == "Harry Potter").Select(w => (w.Name, w.Year));
        }

        public static IEnumerable<Wizard> ExtReverseFiesta()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name);
        }

        public static IEnumerable<string> AllRowling()
        {
            var wizards = Wizard.Wizards.Value;

            var w1 =    from w in wizards 
                        where w.Creator == "J.K. Rowling"
                        select w.Name;
            
            return w1;   
        }

        public static Wizard FirstSithLord()
        {
            var wizards = Wizard.Wizards.Value;

            var w2 = from w in wizards
                    where w.Name.Contains("Darth")
                    orderby w.Year
                    select w;

            return w2.First();
        }

        public static IEnumerable<(string, int?)> UniqueHarryPotter()
        {
            var wizards = Wizard.Wizards.Value;

            var w3 = from w in wizards
                    where w.Medium == "Harry Potter"
                    select (w.Name, w.Year);
            
            return w3;
                    
        }

        public static IEnumerable<string> ReverseFiesta()
        {
            var wizards = Wizard.Wizards.Value;

            //return wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name);

            var w4 =    from w in wizards
                        orderby w.Name descending
                        orderby w.Creator descending
                        group w by new {w.Creator, w.Name} into g
                        select g.Key.Name;
            
            return w4;

        }
    }
}
