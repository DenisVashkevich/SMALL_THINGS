using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallThings.Models;

namespace SmallThings.Interfaces
{
	public interface IProductProcessingStrategy
	{
		void ProcessProduct(ref ProductBase product);
	}
}
