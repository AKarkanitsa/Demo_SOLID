using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{

	/// <summary>
	/// Simple Book Class. No privet fields so we don't need to deel with 
	/// getters and setters and can focus on logic instead
	/// </summary>
	class Book
	{
		public String name;
		public String authorName;
		public int year;
		public int price;
		public String isbn;

		public Book(String name, String authorName, int year, int price, String isbn)
		{
			this.name = name;
			this.authorName = authorName;
			this.year = year;
			this.price = price;
			this.isbn = isbn;
		}
	}
}
