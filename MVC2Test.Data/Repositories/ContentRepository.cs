using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVC2Test.Domain.RepositoryInterfaces;
using MVC2Test.Domain;

namespace MVC2Test.Data.Repositories
{
	public class ContentRepository : IContentRepository
	{
		private ContentModelContainer Context;
		public ContentRepository(ContentModelContainer context)
		{
			Context = context;
		}
		#region IContentRepository Members

		List<Domain.Content> IContentRepository.GetContent()
		{
			return Context.Content.ToList();
		}

		#endregion
	}
}
