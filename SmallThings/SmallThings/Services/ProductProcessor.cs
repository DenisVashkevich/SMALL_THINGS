using System.Collections.Generic;
using System.Linq;
using SmallThings.Interfaces;
using SmallThings.Models;

namespace SmallThings.Services
{
	public class ProductProcessor : IProductProcessor
	{
		public void ProcessProduct(Product product)
		{
			ProcessDocuments(product.Documents);
			ProcessFeatures(product.Features);
			ProcessImages(product.Images);
		}

		public void ProcessProduct(Product2 product)
		{
			//Product2 processing logic
		}

		public void ProcessProduct(Product3 product)
		{
			//Product3 processing logic
		}

		private void ProcessImages(List<Image> images)
		{
			if (!images.Any())
			{
				return;
			}

			// Images processing logic
		}

		private void ProcessDocuments(List<Document> documents)
		{
			if (!documents.Any())
			{
				return;
			}

			//Documents processing logic
		}

		private void ProcessFeatures(List<Feature> features)
		{
			if (!features.Any())
			{
				return;
			}

			//Features processing logic
		}
	}
}