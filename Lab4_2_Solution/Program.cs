using System;

namespace Lab4_2_Solution
{

	class MenuItem
	{
		private int ID;
		private string Name;
		private string Description;
		private decimal Price;
		
		public MenuItem(int ID, string Name, string Description, decimal Price)
		{
			SetID(ID);
			SetName(Name);
			SetDescription(Description);
			SetPrice(Price);
		}
		public MenuItem(int ID, string Name, decimal Price)
		{
			SetID(ID);
			SetName(Name);
			SetDescription("EMPTY");
			SetPrice(Price);
		}

		public int GetID()
		{
			return ID;
		}

		public void SetID(int ID)
		{
			this.ID = ID;
		}

		public string GetName()
		{
			return Name;
		}

		public void SetName(string Name)
		{
			if (Name == "")
			{
				Name = "EMPTY";
			}
			this.Name = Name;
		}

		public string GetDescription()
		{
			return Description;
		}

		public void SetDescription(string Description)
		{
			if (Description =="")
			{
				Description = "EMPTY";
			}
			this.Description = Description;
		}

		public decimal GetPrice()
		{
			return Price;
		}

		public void SetPrice(decimal Price)
		{
			if (Price < 0.50m)
			{
				Price = 0.50m;
			}
			if (Price > 10.00m)
			{
				Price = 10.00m;
			}
			this.Price = Price;
		}

		public override string ToString()
		{
			return $"Details: {ID} {Name} {Description} {Price}";
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			MenuItem test1 = new MenuItem(3, "Greetings", "Hello world", 0.01m);
			Console.WriteLine(test1); // Expect 3 Greetings Hello world 0.50
			Console.WriteLine(test1.GetPrice()); // Expect 0.50
			test1.SetID(5);
			Console.WriteLine(test1.GetID()); // Expect 5
			test1.SetName("Hello");
			Console.WriteLine(test1.GetName()); // Expect Hello
			test1.SetName("");
			Console.WriteLine(test1.GetName()); // Expect EMPTY
			test1.SetDescription("Here's my description");
			Console.WriteLine(test1.GetDescription());  // Expect Here's my description
			test1.SetDescription("");
			Console.WriteLine(test1.GetDescription()); // Expect EMPTY

			// Let's test the price

			test1.SetPrice(5.00m);
			Console.WriteLine(test1.GetPrice()); // Expect 5.00
			test1.SetPrice(11.00m);
			Console.WriteLine(test1.GetPrice()); // Expect 10.00
			test1.SetPrice(0.25m);
			Console.WriteLine(test1.GetPrice()); // Expect 0.50
			test1.SetPrice(10.00m);
			Console.WriteLine(test1.GetPrice()); // Expect 10.00
			test1.SetPrice(0.50m);
			Console.WriteLine(test1.GetPrice()); // Expect 0.50
		}
	}
}
