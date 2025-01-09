
namespace SportzInstractive_Assignment
{
	public class Question3
	{
		public void question3()
		{
			Console.WriteLine("Question 3 : Write a program to swap two numbers without using a temp variable in C#.");
			Console.WriteLine("Output :");
			int a = 10, b = 20;

			Console.WriteLine("Before swapping: a ="+ a +", b = "+b);


			a = a + b;
			b = a - b;
			a = a - b; 

			Console.WriteLine("After swapping: a =" + a + ", b = "+b);
		}
	}
}