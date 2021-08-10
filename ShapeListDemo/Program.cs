using System;
using System.Collections.Generic;

namespace ShapeListDemo
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
		public static void ListAreas(List<Shape> mylist)
		{
			foreach (Shape myshape in mylist)
			{
				Console.WriteLine(myshape);
			}
		}

		// This function returns the first one it finds, and it only returns one instance of Shape
		// If it doesn't find anything, it returns null.
		public static Shape FindOne(List<Shape> mylist, string searchname)
		{
			foreach (Shape myshape in mylist)
			{
				if (myshape.Name.StartsWith(searchname) == true)
				{
					return myshape;
				}
			}
			return null;
		}

		// This function returns a list of all the ones it found.
		// If it doesn't find any, it returns an empty list.
		public static List<Shape> FindAll(List<Shape> mylist, string searchname)
		{
			List<Shape> result = new List<Shape>();
			foreach (Shape myshape in mylist)
			{
				if (myshape.Name.StartsWith(searchname) == true)
				{
					result.Add(myshape);
				}
			}
			return result;
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

	// This is a class that holds shapes.
	//   It has two public members:
	//      Add: This lets the user add a new shape
	//      ListShapes: This prints out all the shapes in the list
	//   These two methods are our public interface, through which we interact with an instance of this class
	//   Later I can replace the inner machinery (i.e. the List<Shape>) with something else, and as long
	//      as I don't change the two public functions, the people using the class won't have to change anything.
	class ShapeList
	{
		private List<Shape> AllShapes = new List<Shape>(); // Internal machinery that the outside world doesn't see.

		public void Add(Shape _shape)
		{
			AllShapes.Add(_shape);
		}

		public void ListShapes()
		{
			foreach (Shape next in AllShapes)
			{
				Console.WriteLine(next);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Shape> myshapes = new List<Shape>();

			Rectangle r1 = new Rectangle(15.0, 20.0, "Sign out front");
			myshapes.Add(r1);

			r1 = new Rectangle(5.4, 6.8, "Sign out back");
			myshapes.Add(r1);

			Circle c1 = new Circle(8.5, "Tire");
			myshapes.Add(c1);

			c1 = new Circle(2.6, "Frying pan");
			myshapes.Add(c1);

			Shape.ListAreas(myshapes);

			Console.WriteLine("\nTry our first search function");
			Shape found = Shape.FindOne(myshapes, "Fry");
			Console.WriteLine(found);

			Console.WriteLine("\nTry our second search function");
			List<Shape> foundlist = Shape.FindAll(myshapes, "Sign");
			Shape.ListAreas(foundlist);

			// Try out the ShapeList class

			Console.WriteLine("\nTesting the ShapeList class");
			ShapeList mylist = new ShapeList();
			Shape sh = new Rectangle(10, 20, "First");
			mylist.Add(sh);

			sh = new Circle(6, "Second");
			mylist.Add(sh);

			mylist.ListShapes();

			

			/*
			 * Alternate way:
			
			List<Shape> myshapes = new List<Shape>();

			Shape sh = new Rectangle(15.0, 20.0, "Sign out front");
			myshapes.Add(sh);

			sh = new Rectangle(5.4, 6.8, "Phone");
			myshapes.Add(sh);

			sh = new Circle(8.5, "Tire");
			myshapes.Add(sh);

			sh = new Circle(2.6, "Frying pan");
			myshapes.Add(sh);

			Shape.ListAreas(myshapes);

			*/

		}
	}
}
