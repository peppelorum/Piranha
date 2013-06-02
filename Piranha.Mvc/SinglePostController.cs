﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Piranha.Models;

namespace Piranha.Mvc
{
	/// <summary>
	/// The single post controller is the base controller from which all controllers
	/// representing a post should derive from.
	/// </summary>
	public class SinglePostController : BaseController
	{
		/// <summary>
		/// Gets the current post model.
		/// </summary>
		/// <returns>The model</returns>
		public PostModel GetModel() {
			return GetModel<PostModel>(CurrentPermalink) ;
		}

		/// <summary>
		/// Gets the current model.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <returns>The model</returns>
		public T GetModel<T>() where T : PostModel {
			return GetModel<T>(CurrentPermalink) ;
		}

		/// <summary>
		/// Gets the post model identified by the given permalink.
		/// </summary>
		/// <param name="permalink">The permalink</param>
		/// <returns>The model</returns>
		public PostModel GetModel(string permalink) {
			return GetModel<PostModel>(permalink) ;
		}

		/// <summary>
		/// Gets the model identified by the given permalink.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <param name="permalink">The permalink</param>
		/// <returns>The model</returns>
		public T GetModel<T>(string permalink) where T : PostModel {
			var m = PostModel.GetByPermalink<T>(permalink) ;

			HttpContext.Items["Piranha_CurrentPage"] = null ;
			HttpContext.Items["Piranha_CurrentPost"] = m.Post ;

			return m ;
		}
	}
}
