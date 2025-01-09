
namespace SportzInstractive_Assignment
{
	public sealed class Question5
	{
		private double radius;
		public Question5(double radius)
		{
			this.radius = radius;
		}
		public double Calculate(Func<double, double> op)
		{
			return op(radius);
		}
	}
}
