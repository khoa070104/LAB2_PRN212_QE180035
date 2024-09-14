using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KhoaNA.Models
{
	public class Product
	{
        public string Name { get; set; }
		public double Price { get; set; }
        public double Discount { get; set; }

		public void Input()
		{
            Console.WriteLine("______ ENTER PRODUCT ______");
            Console.Write("Enter product name: ");
			Name = Console.ReadLine();
			bool test = false;
			double TempPrice = 0, TempDiscount = 0;
			while (!test)
			{
				Console.Write("Enter product price: ");
				test = double.TryParse(Console.ReadLine(), out TempPrice);
			}
			Price = TempPrice;
			test = false;
			while (!test)
			{
				Console.Write("Enter product discount: ");
				test = double.TryParse(Console.ReadLine(), out TempDiscount);
			}
			Discount = TempDiscount;


		}
		private double GetImportTax()
		{
			return Price * 0.10;
		}

		public void Display()
		{
			if(Discount != 0)
			{
				Console.WriteLine($"Name: {Name} ||Price: {Price} ||Discount: {Discount}");
			}
            else Console.WriteLine($"Name: {Name} ||Price: {Price} ||No Discount");
		}

	}
}
