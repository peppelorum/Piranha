﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Piranha.WebPages
{
	/// <summary>
	/// The different hook in the core that the application can attach
	/// itself to.
	/// </summary>
	public static class Hooks {
		/// <summary>
		/// The different hooks available for the breadcrumb.
		/// </summary>
		public static class Breadcrumb {
			/// <summary>
			/// Renders the start of the breadcrumb.
			/// </summary>
			public static Delegates.BreadcrumbStartHook RenderStart ;

			/// <summary>
			/// Renders the end of the breadcrumb.
			/// </summary>
			public static Delegates.BreadcrumbEndHook RenderEnd ;

			/// <summary>
			/// Renders a breadcrumb item.
			/// </summary>
			public static Delegates.BreadcrumbItemHook RenderItem ;

			/// <summary>
			/// Renders the currently active breadcrumb item.
			/// </summary>
			public static Delegates.BreadcrumbItemHook RenderActiveItem ;
		}

		/// <summary>
		/// The different hooks available for the head.
		/// </summary>
		public static class Head {
			/// <summary>
			/// Renders optional information in the head.
			/// </summary>
			public static Delegates.HeadHook Render ;
		}

		/// <summary>
		/// The different hooks availble for the menu.
		/// </summary>
		public static class Menu {
			/// <summary>
			/// Renders the start of a menu level.
			/// </summary>
			public static Delegates.MenuLevelHook RenderLevelStart ;

			/// <summary>
			/// Renders the end of a menu level.
			/// </summary>
			public static Delegates.MenuLevelHook RenderLevelEnd ;

			/// <summary>
			/// Renders the start of a menu item.
			/// </summary>
			public static Delegates.MenuItemHook RenderItemStart ;

			/// <summary>
			/// Renders the end of a menu item.
			/// </summary>
			public static Delegates.MenuItemHook RenderItemEnd ;

			/// <summary>
			/// Renders the menu item link.
			/// </summary>
			public static Delegates.MenuItemLinkHook RenderItemLink ;
		}

		/// <summary>
		/// The different model hooks available for the application.
		/// </summary>
		public static class Model { 
			/// <summary>
			/// Executed after the page model is loaded.
			/// </summary>
			public static Delegates.ModelLoadedHook<Models.PageModel> PageModelLoaded ;

			/// <summary>
			/// Executed after the page model is loaded.
			/// </summary>
			public static Delegates.ModelLoadedHook<Models.PostModel> PostModelLoaded ;
		}

		/// <summary>
		/// The different hooks available for the manager area.
		/// </summary>
		public static class Manager {
			/// <summary>
			/// Executed after the post list model is loaded but before the view is called.
			/// </summary>
			public static Delegates.ManagerModelLoadedHook<Areas.Manager.Models.PostListModel> PostListModelLoaded ;

			/// <summary>
			/// Executed after the post edit model is loaded but before the view is called.
			/// </summary>
			public static Delegates.ManagerModelLoadedHook<Models.Manager.PostModels.EditModel> PostEditModelLoaded ;

			/// <summary>
			/// Executed after the page list model is loaded but before the view is called.
			/// </summary>
			public static Delegates.ManagerModelLoadedHook<Models.Manager.PageModels.ListModel> PageListModelLoaded ;

			/// <summary>
			/// Executed after the page edit model is loaded but before the view is called.
			/// </summary>
			public static Delegates.ManagerModelLoadedHook<Models.Manager.PageModels.EditModel> PageEditModelLoaded ;

			/// <summary>
			/// Executed after the user list model is loaded but before the view is called.
			/// </summary>
			public static Delegates.ManagerModelLoadedHook<Models.Manager.SettingModels.UserListModel> UserListModelLoaded ;

			/// <summary>
			/// Executed after the user edit model is loaded but before the view is called.
			/// </summary>
			public static Delegates.ManagerModelLoadedHook<Models.Manager.SettingModels.UserEditModel> UserEditModelLoaded ;

			/// <summary>
			/// The different hooks available for the toolbar.
			/// </summary>
			public static class Toolbar {
				/// <summary>
				/// Executed when the manager toolbar for the page list is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Models.Manager.PageModels.ListModel> PageListToolbarRender ;
				
				/// <summary>
				/// Executed when the manager toolbar for the page edit view is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Models.Manager.PageModels.EditModel> PageEditToolbarRender ;

				/// <summary>
				/// Executed when the manager toolbar for the post list is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Areas.Manager.Models.PostListModel> PostListToolbarRender ;

				/// <summary>
				/// Executed when the manager toolbar for the post edit view is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Models.Manager.PostModels.EditModel> PostEditToolbarRender ;

				/// <summary>
				/// Executed when the manager toolbar for the media list is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Models.Manager.ContentModels.ListModel> MediaListToolbarRender ;

				/// <summary>
				/// Executed when the manager toolbar for the media edit view is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Models.Manager.ContentModels.EditModel> MediaEditToolbarRender ;

				/// <summary>
				/// Executed when the manager toolbar for the site list is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Areas.Manager.Models.SiteTreeListModel> SiteListToolbarRender ;

				/// <summary>
				/// Executed when the manager toolbar for the site edit view is rendered.
				/// </summary>
				public static Delegates.ManagerToolbarRender<Areas.Manager.Models.SiteTreeEditModel> SiteEditToolbarRender ;

				/// <summary>
				/// Renders the toolbar.
				/// </summary>
				/// <param name="url">The url</param>
				/// <param name="model">The current model</param>
				/// <returns>The rendered html</returns>
				public static HtmlString Render(UrlHelper url, object model) {
					StringBuilder str = new StringBuilder() ;

					if (model is Models.Manager.PageModels.ListModel && PageListToolbarRender != null)
						PageListToolbarRender(url, str, (Models.Manager.PageModels.ListModel)model) ;
					else if (model is Models.Manager.PageModels.EditModel && PageEditToolbarRender != null)
						PageEditToolbarRender(url, str, (Models.Manager.PageModels.EditModel)model) ;
					else if (model is Areas.Manager.Models.PostListModel && PostListToolbarRender != null)
						PostListToolbarRender(url, str, (Areas.Manager.Models.PostListModel)model) ;
					else if (model is Models.Manager.PostModels.EditModel && PostEditToolbarRender != null)
						PostEditToolbarRender(url, str, (Models.Manager.PostModels.EditModel)model) ;
					else if (model is Models.Manager.ContentModels.ListModel && MediaListToolbarRender != null)
						MediaListToolbarRender(url, str, (Models.Manager.ContentModels.ListModel)model) ;
					else if (model is Models.Manager.ContentModels.EditModel && MediaEditToolbarRender != null)
						MediaEditToolbarRender(url, str, (Models.Manager.ContentModels.EditModel)model) ;
					else if (model is Areas.Manager.Models.SiteTreeListModel && SiteListToolbarRender != null)
						SiteListToolbarRender(url, str, (Areas.Manager.Models.SiteTreeListModel)model) ;
					else if (model is Areas.Manager.Models.SiteTreeEditModel && SiteEditToolbarRender != null)
						SiteEditToolbarRender(url, str, (Areas.Manager.Models.SiteTreeEditModel)model) ;

					return new HtmlString(str.ToString()) ;
				}
			}
		}

		public static class Mail
		{
			[Obsolete("Please use Piranha.WebPages.Hooks.Mail.SendPassword instead")]
			public static Delegates.SendPasswordMail SendPasswordMail ;
			public static Delegates.SendPassword SendPassword ;
		}
	}
}
