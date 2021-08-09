using System;

namespace ToStringDemo
{

	class Rectangle
	{
		public double Length;
		public double Width;

		public override string ToString()
		{
			return $"This is a rectangle! {Length}x{Width}";
		}
	}

	class Circle
	{
		public double radius;
		public override string ToString()
		{
			return $"This is a circle! It has radius {radius}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle() { Length = 10.0, Width = 15.0 };
			Circle c1 = new Circle() { radius = 3.5 };

			// Think about the steps here. We're passing an object
			// into WriteLine. The WriteLine function then calls that
			// object's ToString function, and it always call the
			// right one based on the object.
			Console.WriteLine(r1);
			Console.WriteLine(c1);
		}
	}
}
