
using System.Numerics;

namespace SportzInstractive_Assignment
{
	public class Question10
	{
		public void question10()
		{
			Console.WriteLine("Question 10: Write a program to update the “IsRetired” flag for all players,without using any loops.");
			Console.WriteLine("Player List:");
			List<Player> players = new List<Player>
			{
			new Player { PlayerName = "Virat Kholi", IsRetired = 1 },
			new Player { PlayerName = "M.S. Dhoni", IsRetired = 1 },
			new Player { PlayerName = "Hardik Pandya", IsRetired = 1 },
			new Player { PlayerName = "Rohit Sharma", IsRetired = 1 },
			new Player { PlayerName = "Sachin Tendulkar", IsRetired = 0 },
			new Player { PlayerName = "Rahul Dravid", IsRetired = 0 },
			new Player { PlayerName = "Sourav Ganguly", IsRetired = 0 },
			new Player { PlayerName = "VVS Laxman", IsRetired = 0 }
		};
			players.ForEach(p => p.IsRetired = p.IsRetired == 1 ? 0 : 1);

			Console.WriteLine("Updated Player List:");
			foreach (var player in players)
			{
				Console.WriteLine($"Player: {player.PlayerName}, IsRetired: {player.IsRetired}");
			}

		}
	}
}
public class Player
{
	public string PlayerName { get; set; }
	public int IsRetired { get; set; }
}
