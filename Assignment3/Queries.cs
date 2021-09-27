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
    }
}
