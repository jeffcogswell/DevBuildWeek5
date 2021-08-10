using System;
using System.Collections.Generic;

namespace ProtectedDemo2
{
	// Jeff's rule of thumb on private vs protected
	//   If I know there's a zero chance of me deriving classes (e.g. databases) then I'll make them all private
	//   If I think there's any chance I might end up deriving classes, then I just make them all protected


	class Shape
	{
		protected string Name;

		// When we have only constructors that take parameters, the derived classes MUST call one of these constructors.
		// In other words, we don't have a default constructor that takes zero parameters, so the derived classes
		// need to call this one Shape(string) constructor.
		public Shape(string _Name)
		{
			//Console.WriteLine("Inside shape constructor");
			SetName(_Name);
		}

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

		public Rectangle(double _Length, double _Width, string _MyName) : base(_MyName)
		{
			Length = _Length;
			Width = _Width;
			//Console.WriteLine("Inside rectangle constructor");
		}

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
		public Circle(double _Radius, string _Name) : base(_Name)
		{
			Radius = _Radius;
			//Console.WriteLine("Inside circle constructor");
		}
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

			Rectangle r1 = new Rectangle(15.0, 20.0, "Sign out front");
			//r1.SetName("Sign out front");
			myshapes.Add(r1);

			r1 = new Rectangle(5.4, 6.8, "Phone");
			//r1.SetName("Phone");
			myshapes.Add(r1);

			Circle c1 = new Circle(8.5, "Tire");
			//c1.SetName("Tire");
			myshapes.Add(c1);

			c1 = new Circle(2.6, "Frying pan");
			//c1.SetName("Frying pan");
			myshapes.Add(c1);

			ListAreas(myshapes);
		}
	}
}
