using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace MVC2Test.Domain
{
	public interface IContentModelContainer
	{
		int SaveChanges();
	}
}
