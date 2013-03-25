﻿using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebPages;

using RazorGenerator.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Piranha.Manager.ManagerModule), "Init")]

namespace Piranha.Manager
{
	/// <summary>
	/// Static class responsible for starting the manager module.
	/// </summary>
	public static class ManagerModule
	{
		#region Members
		private static string[] ExtensionsFolder = new[] { "~/Areas/Manager/Views/Extensions/{0}.cshtml" };
		#endregion

		/// <summary>
		/// Create the view engine.
		/// </summary>
		public static void Init() {
			// Create new precompiled view engine
            var engine = new PrecompiledMvcEngine(typeof(ManagerModule).Assembly) {
                UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            } ;
			engine.PartialViewLocationFormats = engine.PartialViewLocationFormats.Union(ExtensionsFolder).ToArray();

            ViewEngines.Engines.Add(engine) ;
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine) ;

			// Register the manager area
			var manager = new ManagerRegistration() ;
			var context = new AreaRegistrationContext(manager.AreaName, RouteTable.Routes) ;
			manager.RegisterArea(context) ;

			// Register custom model binders
			RegisterBinders() ;

			// Register json deserialization for post data
			ValueProviderFactories.Factories.Add(new JsonValueProviderFactory());

			// Register application part
			ApplicationPart.Register(new ApplicationPart(typeof(ManagerModule).Assembly, "~/")) ;
		}

		#region Private methods
		/// <summary>
		/// Registers all custom model binders for the manager.
		/// </summary>
		private static void RegisterBinders() {
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.PageModels.EditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.PageModels.EditModel), 
					new Piranha.Models.Manager.PageModels.EditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.PostModels.EditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.PostModels.EditModel), 
					new Piranha.Models.Manager.PostModels.EditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.TemplateModels.PageEditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.TemplateModels.PageEditModel),
					new Piranha.Models.Manager.TemplateModels.PageEditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.TemplateModels.PostEditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.TemplateModels.PostEditModel),
					new Piranha.Models.Manager.TemplateModels.PostEditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.CategoryModels.EditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.CategoryModels.EditModel),
					new Piranha.Models.Manager.CategoryModels.EditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.SettingModels.UserEditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.SettingModels.UserEditModel),
					new Piranha.Models.Manager.SettingModels.UserEditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Models.Manager.ContentModels.EditModel)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Models.Manager.ContentModels.EditModel),
					new Piranha.Models.Manager.ContentModels.EditModel.Binder()) ;
			if (ModelBinders.Binders[typeof(Piranha.Extend.IExtension)] == null)
				ModelBinders.Binders.Add(typeof(Piranha.Extend.IExtension),
					new Piranha.Mvc.ModelBinders.IExtensionBinder()) ;
		}
		#endregion
	}
}