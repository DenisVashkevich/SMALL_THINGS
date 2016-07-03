using SmallThings.Interfaces;

namespace SmallThings.Models
{
	public class Product2 : ProductBase
	{
		public override void ApplyProductProcessor(IProductProcessor processor)
		{
			processor.ProcessProduct(this);
		}
	}
}
