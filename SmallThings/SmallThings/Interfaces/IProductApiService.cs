using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using SmallThings.Models;

namespace SmallThings.Interfaces
{
	public interface IProductApiService
	{
		IEnumerable<Product> FetchProducts(int countToFetch);
	}
}