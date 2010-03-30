using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC2Test.Domain.RepositoryInterfaces
{
	public interface IContentRepository
	{
		List<Content> GetContent();
	}
}
