using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoaNA.Models
{
	public class ProductWithDataFields
	{
		private string _name;
		private double _price;
		private double _discount;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		
		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

		public double Discount
		{
			get { return _discount; }
			set { _discount = value; }
		}
	}
}
