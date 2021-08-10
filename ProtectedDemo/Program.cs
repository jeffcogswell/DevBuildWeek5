using System;
using System.Collections.Generic;

namespace ProtectedDemo
{
	// Jeff's rule of thumb on private vs protected
	//   If I know there's a zero chance of me deriving classes (e.g. databases) then I'll make them all private
	//   If I think there's any chance I might end up deriving classes, then I just make them all protected


	class Shape
	{
		protected string Name;
		public void SetName(string _Name)
		{
			Name = _Name;
		}
		public virtual double GetArea()
		{
			return 0;
		}
	}

	class Rectangle : Shape
	{
		public double Length;
		public double Width;
		public override double GetArea()
		{
			return Length * Width;
		}

		public override string ToString()
		{
			return $"Rectangle called {Name} has area {GetArea()}";
		}
	}

	class Circle : Shape
	{
		public double Radius;
		public override double GetArea()
		{
			return Math.PI * Radius * Radius;
		}
		public override string ToString()
		{
			return $"Circle called {Name} has area {GetArea()}";
		}
	}

	class Program
	{

		static void ListAreas(List<Shape> mylist)
		{
			foreach (Shape myshape in mylist)
			{
				Console.WriteLine(myshape);
			}
		}

		static void Main(string[] args)
		{
			List<Shape> myshapes = new List<Shape>();

			Rectangle r1 = new Rectangle() { Length = 15.0, Width = 20.0 };
			r1.SetName("Sign out front");
			myshapes.Add(r1);

			r1 = new Rectangle() { Length = 5.4, Width = 6.8 };
			r1.SetName("Phone");
			myshapes.Add(r1);

			Circle c1 = new Circle() { Radius = 8.5 };
			c1.SetName("Tire");
			myshapes.Add(c1);

			c1 = new Circle() { Radius = 2.6 };
			c1.SetName("Frying pan");
			myshapes.Add(c1);

			ListAreas(myshapes);
		}
	}
}
