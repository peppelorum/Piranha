﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Core extensions for the MVC library.
/// </summary>
public static class Extensions
{
	/// <summary>
	/// Gets the view for model.
	/// </summary>
	/// <param name="m">The page model</param>
	/// <returns>The view</returns>
	public static string GetView(this Piranha.Models.PageModel m) {
		return ((Piranha.Models.Page)m.Page).View ;
	}

	/// <summary>
	/// Gets the view for model.
	/// </summary>
	/// <param name="m">The post model</param>
	/// <returns>The view</returns>
	public static string GetView(this Piranha.Models.PostModel m) {
		return ((Piranha.Models.Post)m.Post).View ;
	}
}

