using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL.Repositories
{
	public class CategoryRepository
	{
		private readonly HttpClient client;
		/// <summary>
		/// A comment about what this does
		/// </summary>
		/// <param name="client"></param>
		public CategoryRepository(HttpClient client)
		{
			this.client = client;

		}
	}
}
