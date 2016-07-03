using System.Collections.ObjectModel;
using System.Collections.Specialized;
using SmallThings.Interfaces;
using SmallThings.Models;
using SmallThings.Services;

namespace SmallThings
{
	class Program
	{
		private static IProductProcessor _productProcessor = new ProductProcessor();

		static void Main(string[] args)
		{
			var productApiService = new ProductApiService();
			var products = new ObservableCollection<ProductBase>();

			products.CollectionChanged += OnProductsCollectionChanged;

			var newProducts = productApiService.FetchProducts(20);

			foreach (var product in newProducts)
			{
				products.Add(product);
			}

		}

		private static void OnProductsCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
		{
			foreach (var newItem in args.NewItems)
			{
				var item = newItem as ProductBase;

				item?.ApplyProductProcessor(_productProcessor);
			}
		}

	}
}
