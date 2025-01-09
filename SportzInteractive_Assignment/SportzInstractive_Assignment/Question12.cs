
using Newtonsoft.Json;
using System.Numerics;
using System.Xml;

namespace SportzInstractive_Assignment
{
	public class Question12
	{
		public void question12()
		{
			Console.WriteLine("Question 12: Display all the players in the lineups and the number of wickets they have taken.");
			Console.WriteLine("Output:");

			List<Player2> lineups = new List<Player2>
		{
			new Player2 { PlayerId = 21, PlayerName = "Y. Chahal" },
			new Player2 { PlayerId = 22, PlayerName = "Bhuvneshwar Kumar" },
			new Player2 { PlayerId = 23, PlayerName = "Jasprit Bumrah" },
			new Player2 { PlayerId = 24, PlayerName = "Hardik Pandya" },
			new Player2 { PlayerId = 25, PlayerName = "Ravindra Jadeja" },
			new Player2 { PlayerId = 26, PlayerName = "Mohammed Shami" }
		};

			List<BowlingStat> bowlingStats = new List<BowlingStat>
		{
			 new BowlingStat { PlayerId = 21, Wickets = 2 },
			new BowlingStat { PlayerId = 22, Wickets = 1 },
			new BowlingStat { PlayerId = 23, Wickets = 3 },
			new BowlingStat { PlayerId = 26, Wickets = 1 }
		};

			var playerWickets = from player in lineups
								join stats in bowlingStats on player.PlayerId equals stats.PlayerId into statsGroup
								from stat in statsGroup.DefaultIfEmpty()
								select new
								{
									player.PlayerName,
									Wickets = stat?.Wickets ?? 0
								};

			foreach (var player in playerWickets)
			{
				Console.WriteLine(player.PlayerName +":"+ player.Wickets+ "wickets");
			}
		}
	}
}

public class Player2
{
	public int PlayerId { get; set; }
	public string PlayerName { get; set; }
}

public class BowlingStat
{
	public int PlayerId { get; set; }
	public int Wickets { get; set; }
}