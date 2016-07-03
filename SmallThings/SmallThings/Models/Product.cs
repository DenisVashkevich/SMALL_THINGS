using System.Collections.Generic;
using SmallThings.Interfaces;

namespace SmallThings.Models
{
	public class Product : ProductBase
	{
		public List<Document> Documents { get; set; }

		public List<Feature> Features { get; set; }

		public List<Image> Images { get; set; }

		public Product()
		{
			Documents = new List<Document>();
			Images = new List<Image>();
			Features = new List<Feature>();
		}

		public override void ApplyProductProcessor(IProductProcessor processor)
		{
			processor.ProcessProduct(this);
		}
	}
}