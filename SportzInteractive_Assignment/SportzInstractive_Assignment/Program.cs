namespace SportzInstractive_Assignment
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Question1 obj = new Question1();
			obj.question1();
			Console.WriteLine("---------------------------------------------------------------------------------------");

			Question2 obj2 = new Question2();
			obj2.question2();
			Console.WriteLine("---------------------------------------------------------------------------------------");

			Question3 obj3 = new Question3();
			obj3.question3();
			Console.WriteLine("---------------------------------------------------------------------------------------");

			Question5 obj5 = new Question5(5.0);
			double circumference = obj5.Calculate(r => 2 * Math.PI * r);
			Console.WriteLine("Question 5: Write code to calculate the circumference of the circle, without modifying the Circle class itself");
			Console.WriteLine("Output :");
			Console.WriteLine("Circumference: " + circumference);
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question6 obj6 = new Question6();
			obj6.question6();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question7 obj7 = new Question7();
			obj7.question7();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question8 obj8 = new Question8();
			obj8.question8(5);
			obj8.question8(8, 4);
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question9 obj9 = new Question9();
			obj9.question9();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question10 obj10 = new Question10();
			obj10.question10();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question11 obj11 = new Question11();
			obj11.question11();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question12 obj12 = new Question12();
			obj12.question12();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			Question4 obj4 = new Question4();
			obj4.question4();
			Console.WriteLine("-----------------------------------------------------------------------------------------");

			
			Console.WriteLine("-----------------------------------------------------------------------------------------");




		}
	}
}
