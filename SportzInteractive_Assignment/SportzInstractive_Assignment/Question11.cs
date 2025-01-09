
using Newtonsoft.Json;
using System.Numerics;
using System.Xml;

namespace SportzInstractive_Assignment
{
	public class Question11
	{
		public void question11()
		{
			Console.WriteLine("Question 11: Create a C# object which returns the following JSON result when serialized.");
			Console.WriteLine("Output:");

			Team team = new Team
			{
				Name_Full = "Sunrisers Hyderabad",
				Name_Short = "SRH",
				Players = new Dictionary<int, Player1>
			{
				{ 5380, new Player1 { Position = 1, Name_Full = "David Warner", IsCaptain = true } },
				{ 3722, new Player1 { Position = 2, Name_Full = "Shikhar Dhawan", IsCaptain = false } }
			}
			};

			string json = JsonConvert.SerializeObject(team, Newtonsoft.Json.Formatting.Indented);
			Console.WriteLine(json);
		}
	}
}
public class Team
{
	public string Name_Full { get; set; }
	public string Name_Short { get; set; }
	public Dictionary<int, Player1> Players { get; set; }
}

public class Player1
{
	public int Position { get; set; }
	public string Name_Full { get; set; }
	public bool IsCaptain { get; set; }
}
