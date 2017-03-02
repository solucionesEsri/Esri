using System;
namespace Northwinder
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double UnitPrice { get; set; }
		public string Package { get; set; }
		public bool IsDiscontinued { get; set; }
	}
}
