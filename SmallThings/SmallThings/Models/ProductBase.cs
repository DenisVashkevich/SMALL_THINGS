using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallThings.Interfaces;

namespace SmallThings.Models
{
	public abstract class ProductBase
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public abstract void ApplyProductProcessor(IProductProcessor processor);

	}
}
