using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void ExtAllRowling_GivenWizards_Returns_DumbelPotterVolde()
        {
            IEnumerable<string> expected = new List<string> { "Albus Dumbeldore", "Harry Potter", "Voldemort"};

            IEnumerable<string> output = Queries.ExtAllRowling();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtFirstSithLord_GivenDarthVader_ReturnsDarthVader()
        {
            var expected = new Wizard { Name="Darth Vader", Medium="Star Wars", Year=1977, Creator="George Lucas" };

            var output = Queries.ExtFirstSithLord();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtUniqueHarryPotter_GivenDumbelPotterVoldemort_ReturnsDumbelPotterVolde()
        {
            var expected = new HashSet<(string, int?)> 
            {
                ("Harry Potter", 1997),
                ("Albus Dumbeldore", 1997),
                ("Voldemort", 1997)   
            };

            var output = Queries.ExtUniqueHarryPotter();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtReverseFiesta()
        {
            var expected = new HashSet<Wizard>
            {
                new Wizard { Name="Dr. Stephen Strange", Medium="Doctor Strange", Year=1963, Creator="Stan Lee" },
                new Wizard { Name="Glinda the Good Witch", Medium="The Wizard of Oz", Year=1900, Creator="L. Frank Baum" },
                new Wizard { Name="Sauron", Medium="The Fellowship of the Rings", Year=1954, Creator="J.R.R. Tolkien" },
                new Wizard { Name="Gandalf", Medium="The Fellowship of the Rings", Year=1954, Creator="J.R.R. Tolkien" },
                new Wizard { Name="Albus Dumbeldore", Medium="Harry Potter", Year=1997, Creator="J.K. Rowling:" },
                new Wizard { Name="Harry Potter", Medium="Harry Potter", Year=1997, Creator="J.K. Rowling"},
                new Wizard { Name="Voldemort", Medium="Harry Potter", Year=1997, Creator="J.K. Rowling"},
                new Wizard { Name="Darth Vader", Medium="Star Wars", Year=1977, Creator="George Lucas"},
                new Wizard { Name="Yoda", Medium="Star Wars", Year=1977, Creator="George Lucas"},
                new Wizard { Name="Merlin", Medium="Arthurian", Year=1903, Creator="Geoffrey of Monmouth"}
            }; 

            var output = Queries.ExtReverseFiesta();

            Assert.Equal(expected, output);
        }
    }
}
