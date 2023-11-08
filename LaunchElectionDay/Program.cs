using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);

var race = new Race("District 12 Hunger Games");

var annie = new Candidate("Annie M", "Democrat");
var asher = new Candidate("Asher", "Democrat");
race.RegisterCandidate(asher);

foreach (var candidate in race.Candidates)
{
    Console.WriteLine(candidate.Name);
}
var election = new Election("2023");
election.AddRace(race);

 Console.WriteLine(election.VoteCount());
