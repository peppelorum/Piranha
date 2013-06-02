﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;

using Piranha.Models;

namespace Piranha.Mvc
{
	/// <summary>
	/// Abstract base class for all Piranha CMS controllers.
	/// </summary>
	public abstract class BaseController : Controller
	{
		#region Members
		/// <summary>
		/// Gets the currently selected permalink.
		/// </summary>
		protected string CurrentPermalink { get ; private set ; }
		#endregion

		/// <summary>
		/// Check if the current user has access to the action before continuing.
		/// </summary>
		/// <param name="context">The current context</param>
		protected override void OnActionExecuting(ActionExecutingContext context) {
			// Get the current permalink
			CurrentPermalink = Request["permalink"] ;

			// Authorize and execute
			if (Authorize(context.ActionDescriptor.ActionName)) {
				base.OnActionExecuting(context) ;
			} else {
				var param = SysParam.GetByName("LOGIN_PAGE") ;
				if (param != null)
					context.Result = Redirect(param.Value) ;
				else context.Result = Redirect("~/") ;
			}
		}

		/// <summary>
		/// Authorizes the current user for the given action.
		/// </summary>
		/// <param name="actionname">The action name</param>
		/// <returns>If the user has access</returns>
		protected virtual bool Authorize(string actionname) {
			MethodInfo m = null ;

			try {
				// Get the method corresponding to the current action.
				m = this.GetType().GetMethod(actionname, BindingFlags.Public|BindingFlags.Instance|BindingFlags.IgnoreCase) ;
			} catch {
				// There are multiple actions with the same name. Match with the http method.
				foreach (var method in this.GetType().GetMethods()) {
					if (method.Name.ToLower() == actionname.ToLower()) {
						if (Request.HttpMethod == "POST") {
							if (method.GetCustomAttribute<HttpPostAttribute>(true) != null) {
								m = method ;
							}
						} else if (Request.HttpMethod == "GET") {
							if (method.GetCustomAttribute<HttpGetAttribute>(true) != null ||
								method.GetCustomAttribute<HttpPostAttribute>(true) == null) {
								m = method ;
							}
						}
					}
				}
			}

			if (m != null) {
				var attr = m.GetCustomAttribute<AccessAttribute>(true) ;
				if (attr != null) {
					if (!User.HasAccess(attr.Function))
						return false ;
				}
			}
			return true ;
		}
	}
}
