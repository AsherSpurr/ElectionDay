namespace LaunchElectionDay
{
	public class Election
	{
		public string Year;
		public List<Race> Races;
		public Election(string year)
		{
			Year = year;
			Races = new List<Race>();
		}

		public void AddRace(Race race)
		{
			Races.Add(race);
		}

		public List<Candidate> AllCandidates()
		{
			var allCandidates = new List<Candidate>();

			foreach (Race race in Races)
			{
				foreach (var candidate in race.Candidates)
				{
					allCandidates.Add(candidate);
				}
			}
			return allCandidates;
		}
		public Dictionary<string, int> VoteCount()
		{
			var voteCount = new Dictionary<string, int>();

			foreach (var candidate in AllCandidates()) 
			{
				voteCount.Add(candidate.Name, candidate.Votes);
			}
			return voteCount;
		}
	}
}

