
namespace SportzInstractive_Assignment
{
	public class Question9
	{
		public void question9()
		{
			Console.WriteLine("Question 9: write a program that will return the batsman with the best batting momentum");
			Console.WriteLine("Output :");

			List<Batsman> batsmen = new List<Batsman>
		{
			new Batsman { BatsmanName = "Virat Kholi", RunsScored = 50, StrikeRate = 78.30 },
			new Batsman { BatsmanName = "M.S.Dhoni", RunsScored = 61, StrikeRate = 58.90 },
			new Batsman { BatsmanName = "Rohit Sharma", RunsScored = 13, StrikeRate = 124.0 }
		};

			var bestBatsman = batsmen.OrderByDescending(b => b.RunsScored * b.StrikeRate).First();

			Console.WriteLine("The batsman with the best batting momentum is:"+ bestBatsman.BatsmanName);
		}
	}
}
public class Batsman
{
	public string BatsmanName { get; set; }
	public int RunsScored { get; set; }
	public double StrikeRate { get; set; }
}
