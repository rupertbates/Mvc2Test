using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC2Test.Domain;

namespace MVC2Test.Tests.Domain
{
	[TestClass]
	public class TestContent
	{
		[TestMethod]
		public void Test_can_create_content()
		{
			using (var ctx = new ContentModelContainer())
			{
				var content = new Content
				{
					Title = "My first article",
					StandFirst = "My test standfirst",
                    Body = "Ooh yeah love that sexy body"
				};
                var author = new Author
                {
                    FirstName = "Brian",
                    Surname = "Clough"
                };
                content.Author = author;
				ctx.Content.AddObject(content);
                ctx.SaveChanges();
				Assert.AreNotEqual(0, content.Id);
                if (ctx.Authors.Count() == 0)
                    Assert.Fail("Author was not inserted");
                Assert.AreEqual("Brian", content.Author.FirstName);

                content.Title = "A different title";
                ctx.SaveChanges();
                content = ctx.Content.Where(c => c.Title == "A different title").Single();

			}
		}
	}
}
