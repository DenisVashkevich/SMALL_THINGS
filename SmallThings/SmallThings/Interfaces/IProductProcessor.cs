using SmallThings.Models;

namespace SmallThings.Interfaces
{
	public interface IProductProcessor
	{
		void ProcessProduct(Product product);
		void ProcessProduct(Product2 product);
		void ProcessProduct(Product3 product);
	}
}