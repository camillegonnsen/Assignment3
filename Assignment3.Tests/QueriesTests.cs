using System.Collections.Generic;
using Xunit;

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
            Wizard expected = new Wizard { Name="Darth Vader", Medium="Star Wars", Year=1977, Creator="George Lucas" };

            Wizard output = Queries.ExtFirstSithLord();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtUniqueHarryPotter_GivenDumbelPotterVoldemort_ReturnsDumbelPotterVolde()
        {
            IEnumerable<(string, int?)> expected = new List<(string, int?)> 
            {
                ("Harry Potter", 1997),
                ("Albus Dumbeldore", 1997),
                ("Voldemort", 1997)   
            };

            IEnumerable<(string, int?)> output = Queries.ExtUniqueHarryPotter();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtReverseFiesta()
        {
            IEnumerable<string> expected = new List<string>
            {
                "Dr Stephen Strange", "Glinda the Good Witch", "Sauron", "Gandalf", "Voldemort", "Harry Potter", 
                "Albus Dumberldore", "Yoda", "Darth Vader", "Merlin" 
            }; 

            IEnumerable<string>output = Queries.ExtReverseFiesta();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void AllRowling_GivenWizards_Returns_DumbelPotterVolde()
        {
            IEnumerable<string> expected = new List<string> { "Albus Dumbeldore", "Harry Potter", "Voldemort"};

            IEnumerable<string> output = Queries.AllRowling();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void FirstSithLord_GivenDarthVader_ReturnsDarthVader()
        {
            Wizard expected = new Wizard { Name="Darth Vader", Medium="Star Wars", Year=1977, Creator="George Lucas" };

            Wizard output = Queries.FirstSithLord();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void UniqueHarryPotter_GivenDumbelPotterVoldemort_ReturnsDumbelPotterVolde()
        {
            IEnumerable<(string, int?)> expected = new List<(string, int?)> 
            {
                ("Harry Potter", 1997),
                ("Albus Dumbeldore", 1997),
                ("Voldemort", 1997)   
            };

            IEnumerable<(string, int?)> output = Queries.UniqueHarryPotter();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ReverseFiesta()
        {
            IEnumerable<string> expected = new List<string>
            {
                "Dr Stephen Strange", "Glinda the Good Witch", "Sauron", "Gandalf", "Voldemort", "Harry Potter", 
                "Albus Dumberldore", "Yoda", "Darth Vader", "Merlin" 
            }; 

            IEnumerable<string>output = Queries.ReverseFiesta();

            Assert.Equal(expected, output);
        }
    }
}
