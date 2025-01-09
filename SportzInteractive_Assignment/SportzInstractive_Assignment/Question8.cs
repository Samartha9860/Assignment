
namespace SportzInstractive_Assignment
{
	public class Question8
	{
		 public void question8(double side)
		{
			double area = side * side;
			Console.WriteLine("Question 8 : Write an over loaded function in c# to calculate an area of a square or a rectangle");
			Console.WriteLine("Output :");
			Console.WriteLine("The area of the square with side " + side + " is: "+area);
		}
		public void question8(double length, double width)
		{
			double area = length * width;
			Console.WriteLine("The area of the rectangle with length "+length + " and width " + width + " is: " + area);
		}
	}
}