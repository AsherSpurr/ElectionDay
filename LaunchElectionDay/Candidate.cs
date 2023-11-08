namespace LaunchElectionDay
{
    public class Candidate 
    {
        public string Name { get; set; }
        public string Party { get; set; }
        public int Votes = 0;

    public Candidate(string name, string party) 
        {
            Name = name;
            Party = party;
            Votes = 0;
        }

    public void VoteFor()
        {
            Votes++;
        }
    }
}
