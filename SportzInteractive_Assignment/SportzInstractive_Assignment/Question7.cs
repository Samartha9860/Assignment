
using System.ComponentModel;

namespace SportzInstractive_Assignment
{
	public class Question7
	{
		public enum Colors
		{
			red,
			blue,
			green,
			yellow
		}

		public void question7()
		{
			Console.WriteLine("Question 7 : Write a program to iterate through Enum values in C#");
			Console.WriteLine("Output :");

			foreach (Colors color in Enum.GetValues(typeof(Colors)))
			{
				Console.WriteLine(color);
			}
		}
	}
}