using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallThings.Models;

namespace SmallThings.Interfaces
{
	public interface IProductProcessor
	{
		void ProcessProduct(Product product);
	}
}
