using KhoaNA.Models;

namespace Lab2_PRN212
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ex02: 
			Console.WriteLine("--- 02 ---");
			Product pd1 = new Product();
			Product pd2 = new Product();
			pd1.Input();
			pd2.Input();
			pd2.Display();
			pd1.Display();
			//Ex03:
			Console.WriteLine("--- 03 ---");
			Product pd3 = new Product
			{
				Name = "Banana",
				Price = 10
			};
			Product pd4 = new Product
			{
				Name = "Apple",
				Price = 12,
				Discount = 0.05
			};
			pd3.Display();
			pd4.Display();

			// Ex04: 
			ProductWithDataFields pd5 = new ProductWithDataFields();
			pd5.Price = 10;
            Console.WriteLine(pd5.Price);
		}
	}
}
