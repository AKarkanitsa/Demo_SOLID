using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{

	//Wrong class design. Class Invoice violates the Single Responsibility Principle 

	/// <summary>
	/// Invoice class with logic to create invoice and calculate the total price
	/// Our bookstore only sells books and nothing else
	/// </summary>
	class Invoice
	{

		public Book book;
		public int quantity;
		public double discountRate;
		public double taxRate;
		public double total;

		public Invoice(Book book, int quantity, double discountRate, double taxRate)
		{
			this.book = book;
			this.quantity = quantity;
			this.discountRate = discountRate;
			this.taxRate = taxRate;
			this.total = this.calculateTotal();
		}

		//Method, which calculates the total price,
		public double calculateTotal()
		{
			double price = ((book.price - book.price * discountRate) * this.quantity);

			double priceWithTaxes = price * (1 + taxRate);

			return priceWithTaxes;
		}


		//Method to print the invoice to console
		//first violation - printing logic is mixed with business logic
		public void printInvoice()
		{
            Console.WriteLine(quantity + "x " + book.name + " " + book.price + "$");
			Console.WriteLine("Discount Rate: " + discountRate);
			Console.WriteLine("Tax Rate: " + taxRate);
			Console.WriteLine("Total: " + total);
		}

		//Method to save invoice to file
		//second violation  - persistence logic is mixed with business logic.
		//Don't think in terms of writing to a file – it could be saving to a database
		public void saveToFile(String filename)
		{
			// Creates a file with given name and writes the invoice
		}

	}
}
