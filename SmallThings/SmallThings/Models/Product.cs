using System.Collections.ObjectModel;

namespace SmallThings.Models
{
	public class Product
	{
		public ObservableCollection<Document> Documents { get; set; }

		public ObservableCollection<Feature> Features { get; set; }
		public string Id { get; set; }

		public ObservableCollection<Image> Images { get; set; }

		public string Name { get; set; }

		public Product()
		{
			Documents = new ObservableCollection<Document>();
			Images = new ObservableCollection<Image>();
			Features = new ObservableCollection<Feature>();
		}
	}
}