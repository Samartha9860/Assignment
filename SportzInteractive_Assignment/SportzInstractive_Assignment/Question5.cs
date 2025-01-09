
namespace SportzInstractive_Assignment
{
	public sealed class Question6
	{
		public void question6()
		{
			Console.WriteLine("Question 6: Write a program to calculate the power of a number using tail recursion.");
			Console.WriteLine("Output:");

			int baseNumber = 2;
			int exponent = 3;

			int result = Power(baseNumber, exponent, 1);

			Console.WriteLine("The result of " + baseNumber + " raised to the power of " + exponent + " is: " + result);
		}
		public static int Power(int baseNumber, int exponent, int accumulator)
		{
			if (exponent == 0)
			{
				return accumulator;
			}

			return Power(baseNumber, exponent - 1, accumulator * baseNumber);
		}
	}
}
