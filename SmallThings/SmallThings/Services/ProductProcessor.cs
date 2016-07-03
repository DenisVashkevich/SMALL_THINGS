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