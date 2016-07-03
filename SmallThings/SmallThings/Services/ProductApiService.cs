using System.Collections.Generic;
using SmallThings.Interfaces;
using SmallThings.Models;

namespace SmallThings.Services
{
	public class ProductApiService : IProductApiService
	{
		public IEnumerable<Product> FetchProducts(int countToFetch)
		{
			for (var i = 0; i < countToFetch; i++)
			{
				yield return new Product();
			}
		}
	}
}