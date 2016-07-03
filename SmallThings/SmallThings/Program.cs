using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallThings.Interfaces;
using SmallThings.Models;
using SmallThings.Services;

namespace SmallThings
{
	class Program
	{
		

		static void Main(string[] args)
		{
			var productApiService = new ProductApiService();
			var products = new ObservableCollection<Product>();

			products.CollectionChanged += OnProductsCollectionChanged;

			var newProducts = productApiService.FetchProducts(20);

			foreach (var product in newProducts)
			{
				products.Add(product);
			}

		}

		private static void OnProductsCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
		{
			args.
			throw new NotImplementedException();
		}

	}
}
