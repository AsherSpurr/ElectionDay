using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay.UnitTests
{
    public class ElectionTest
    {
        [Fact]
        public void IsCreatedWithAYearAndNoRaces()
        {
            var election = new Election("2023");

            Assert.Equal("2023", election.Year);
            Assert.Equal(new List<Race>(), election.Races);
        }
        [Fact]
        public void AddRace_AddsRaceToList()
        {
            var election = new Election("2023");
            var race1 = new Race("District 2");
            var race2 = new Race("District 2");

            election.AddRace(race1);
            election.AddRace(race2);

            Assert.Equal(new List<Race> { race1, race2 }, election.Races);
        }
        /*[Fact]
        public void VoteCounts_ReturnsVotesPerCandidate()
        {
            var election = new Election("2023");
            var race1 = new Race("District 2");
            var race2 = new Race("District 2");

            var can1 = new Candidate("Asher S", "Democrat");
            var can2 = new Candidate("Annie M", "Democrat");
            can1.VoteFor();
            can1.VoteFor();
            can1.VoteFor();
            can2.VoteFor();

            election.AddRace(race1);
            election.AddRace(race2);
            race1.RegisterCandidate(can1);
            race2.RegisterCandidate(can2);
            var expected = new Dictionary<string, int>()
            {

            }*/
        }
    }

