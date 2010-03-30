using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using MvcContrib.Castle;
using MVC2Test.Domain;
using MVC2Test.Data;
using MVC2Test.Domain.RepositoryInterfaces;
using MVC2Test.Data.Repositories;

namespace MVC2Test
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default",                                              // Route name
				"{controller}/{action}/{id}",                           // URL with parameters
				new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterRoutes(RouteTable.Routes);
			IWindsorContainer container = new WindsorContainer();
			//ObjectContext
			container.Register(Component
				.For<ContentModelContainer>()
				.ImplementedBy<ContentModelContainer>()
				.LifeStyle.PerWebRequest);
			
			//Repositories
			container.Register(Component
				.For<IContentRepository>()
				.ImplementedBy<ContentRepository>()
				.LifeStyle.PerWebRequest);


			//add all controllers to container
			container.Register(AllTypes
									.Of<Controller>()
									.FromAssembly(typeof(MvcApplication).Assembly)
													.Unless(t => t.IsAbstract)); 
			ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container));
			
		}
	}
}