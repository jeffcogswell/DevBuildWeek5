using System;
using System.Collections.Generic;

namespace ListAsMember
{

	class Polygon
	{
		public string Kind; // triangle, rectangle, five-sided, six-sided
		public List<int> Sides; // A list of side lengths (3,4,5) would be a triangle with sides of lengths 3, 4, and 5
		public Polygon(string _Kind, List<int> _Sides)
		{
			Kind = _Kind;
			Sides = _Sides;
		}
		public override string ToString()
		{
			return $"{Kind} {string.Join(',', Sides)}";
		}
		public void AddSide(int n)
		{
			Sides.Add(n);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Test area or scratchpad
			Polygon p1 = new Polygon("Triangle", new List<int>() { 3, 4, 5 });
			//Console.WriteLine(string.Join(':', p1.Sides));

			Console.WriteLine(p1);

			p1.AddSide(10);
			Console.WriteLine(p1);
		}
	}
}
