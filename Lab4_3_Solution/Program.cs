using System;
using System.Collections.Generic;

namespace Lab4_3_Solution
{
	class Customer
	{
		private string Company;
		private string ContactName;
		private string ContactEmail;
		private string Phone;

		public Customer(string _Company, string _ContactName,
			string _ContactEmail, string _Phone)
		{
			Company = _Company;
			ContactName = _ContactName;
			ContactEmail = _ContactEmail;
			Phone = _Phone;
		}

		public string GetCompany()
		{
			return Company;
		}
		public void SetCompany(string _Company)
		{
			Company = _Company;
		}
		public string GetContactName()
		{
			return ContactName;
		}
		public void SetContactName(string _ContactName)
		{
			ContactName = _ContactName;
		}
		public string GetContactEmail()
		{
			return ContactEmail;
		}
		public void SetContactEmail(string _ContactEmail)
		{
			ContactEmail = _ContactEmail;
		}
		public string GetPhone()
		{
			return Phone;
		}
		public void SetPhone(string _Phone)
		{
			Phone = _Phone;
		}

		public override string ToString()
		{
			return $"Company: {Company} Contact: {ContactName} {ContactEmail} Phone: {Phone}";
		}

		public static void ListCustomers(List<Customer> custlist)
		{
			foreach (Customer cust in custlist)
			{
				Console.WriteLine(cust);
			}
		}

		public static Customer SearchCustomer(List<Customer> custlist, string company)
		{
			foreach (Customer cust in custlist)
			{
				if (cust.Company == company)
				{
					return cust;
				}
			}
			return null;
		}

	}

	class Program
	{

		static void Main(string[] args)
		{
			List<Customer> customers = new List<Customer>();
			Customer cust = new Customer("Falls Realty", "Jamal Johnson", "jamal@fallsrealty.com", "2481231234");
			customers.Add(cust);
			cust = new Customer("Haberdasher Hattery", "Otto Ourada", "otto@haber.com", "6163213211");
			customers.Add(cust);
			cust = new Customer("Little Circus", "Ruby Ringwald", "ruby@littlcircus.com", "2489998787");
			customers.Add(cust);

			//Customer.ListCustomers(customers);


			Console.Write("Who would you like to search for? ");
			string entry = Console.ReadLine();
			cust = Customer.SearchCustomer(customers, entry);
			if (cust != null)
			{
				Console.WriteLine(cust);
			}
			else
			{
				Console.WriteLine("Sorry that customer does not exist.");
			}

		}
	}
}
