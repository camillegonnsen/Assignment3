using System.Collections.Generic;
using Xunit;
using System;

namespace Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void ExtAllRowling_GivenWizards_Returns_DumbelPotterVolde()
        {
            List<string> expected = new List<string> { "Albus Dumbledore", "Harry Potter", "Voldemort"};

            var output = Queries.ExtAllRowling();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtFirstSithLord_GivenDarthVader_Returns1977()
        {
            int? expected = 1977;

            var output = Queries.ExtFirstSithLord();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtUniqueHarryPotter_GivenDumbelPotterVoldemort_ReturnsDumbelPotterVolde()
        {
            IEnumerable<(string, int?)> expected = new List<(string, int?)>() 
            {
               
                ("Albus Dumbledore", 1997), ("Harry Potter", 1997),
                ("Voldemort", 1997)   
            };
            var output = Queries.ExtUniqueHarryPotter();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void ExtReverseFiesta()
        {
            IEnumerable<string> expected = new List<string>
              {
                "Dr. Stephen Strange", "Glinda the Good Witch", "Gandalf", "Sauron",  "Albus Dumbledore", "Harry Potter","Voldemort", "Darth Vader",
                "Yoda", "Merlin" 
            }; 

            IEnumerable<string>output = Queries.ExtReverseFiesta();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void AllRowling_GivenWizards_Returns_DumbelPotterVolde()
        {
            IEnumerable<string> expected = new List<string> { "Albus Dumbledore", "Harry Potter", "Voldemort"};

            IEnumerable<string> output = Queries.AllRowling();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void FirstSithLord_GivenDarthVader_Returns1977()
        {
           // Wizard expected = new Wizard { Name="Darth Vader", Medium="Star Wars", Year=1977, Creator="George Lucas" };

            int? expected = 1977;
            var output = Queries.FirstSithLord();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void UniqueHarryPotter_GivenDumbelPotterVoldemort_ReturnsDumbelPotterVolde()
        {
            IEnumerable<(string, int?)> expected = new List<(string, int?)> 
            {
                
                ("Albus Dumbledore", 1997),("Harry Potter", 1997),
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
                "Dr. Stephen Strange", "Glinda the Good Witch", "Sauron", "Gandalf", "Voldemort", "Harry Potter", 
                "Albus Dumbledore", "Yoda", "Darth Vader", "Merlin" 
            }; 

            IEnumerable<string>output = Queries.ReverseFiesta();

            Assert.Equal(expected, output);
        }
    }
}
