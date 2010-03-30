using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2Test.Domain.RepositoryInterfaces;
using MVC2Test.Domain;
namespace MVC2Test.Controllers
{
    public class ContentController : Controller
    {
		private IContentRepository Repository;
		public ContentController(IContentRepository repository)
		{
			Repository = repository;
		}
        //
        // GET: /Content/

        public ActionResult Index()
        {
            return View(Repository.GetContent());
        }

    }
}
