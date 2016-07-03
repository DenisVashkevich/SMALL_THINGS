using System.Collections.Generic;

namespace SmallThings.Models
{
	public class Product
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public List<Document> Documents { get; set; }

		public List<Feature> Features { get; set; }

		public List<Image> Images { get; set; }

		public Product()
		{
			Documents = new List<Document>();
			Images = new List<Image>();
			Features = new List<Feature>();
		}
	}
}