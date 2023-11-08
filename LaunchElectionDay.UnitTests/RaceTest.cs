using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay.UnitTests
{
    public class RaceTest
    {
        [Fact]
        public void Race_NewRaceIsCreated()
        {
            var race = new Race("District 12");
          
            Assert.Equal("District 12", race.Office);
        }
        [Fact]
        /*public void RegisterCandidates_AddsToList()
        {
            var race = new Race("District 12");
            var asher = new Candidate("Asher S", "Democrat");
        var annie = new Candidate("Annie M", "Democrat");

            race.RegisterCandidate(asher);
            race.RegisterCandidate(annie);
            var expected = new List<Race> { asher }
            Assert.Equal(new List<Race>(), race.RegisterCandidate);
        }*/
    }
}
