using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallThings.Interfaces;
using SmallThings.Models;

namespace SmallThings.Services
{
	public class Product2ProcessingStrategy : IProductProcessingStrategy
	{
		public void ProcessProduct(ref ProductBase product)
		{
			//Product2 processing logic
		}
	}
}
