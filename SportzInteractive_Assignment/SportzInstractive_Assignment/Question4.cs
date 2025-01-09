
namespace SportzInstractive_Assignment
{
	public class Question4
	{
		public void question4()
		{
			Console.WriteLine("Question 4: Print the Nth Fibonacci number in the series");
			Console.WriteLine("Output :");

			Console.Write("Enter the value of N: ");
			int N = int.Parse(Console.ReadLine());

			int result = Fibonacci(N);

			Console.WriteLine("The " + N + "th Fibonacci number is: " + result);
		}
		public int Fibonacci(int n)
		{
			if (n <= 1)
				return n;
			else
				return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
	}
}