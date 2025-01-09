
namespace SportzInstractive_Assignment
{
	public class Question1
	{
		public void question1()
		{
			Console.WriteLine("Question 1 : Given an array of integers, write a C# method to total all the values that are even numbers.");
			Console.WriteLine("Input Array : { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }");
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int result = SumEvenNumbers(numbers);
			Console.WriteLine("Output : The sum of the even numbers is: " + result);
		}

		public static int SumEvenNumbers(int[] numbers)
		{
			int sum = 0;

			foreach (int number in numbers)
			{
				if (number % 2 == 0)
				{
					sum += number;
				}
			}

			return sum;
		}
	}
}
