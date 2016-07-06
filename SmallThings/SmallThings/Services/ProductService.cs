using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallThings.Interfaces;

namespace SmallThings.Services
{
	public class ProductService
	{
		private readonly IProductApiService _productApiService;
		private readonly IProductProcessingStrategy _productProcessingStrategy;

		public ProductService(IProductApiService productApiService, IProductProcessingStrategy productProcessingStrategy)
		{
			_productProcessingStrategy = productProcessingStrategy;
			_productApiService = productApiService;
		}

	}
}
