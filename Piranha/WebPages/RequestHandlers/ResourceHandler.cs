﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Piranha.WebPages.RequestHandlers
{
	/// <summary>
	/// The resource handler delivers embedded resources for the manager
	/// with client caching enabled for better performance.
	/// </summary>
	internal class ResourceHandler : IRequestHandler
	{
		#region Inner classes
		/// <summary>
		/// Inner class representing an embedded resource.
		/// </summary>
		class Resource 
		{
			/// <summary>
			/// Gets/sets the resource name.
			/// </summary>
			public string Name { get ; set ; }

			/// <summary>
			/// Gets/sets the content type.
			/// </summary>
			public string ContentType { get ; set ; }
		}
		#endregion

		#region Members
		/// <summary>
		/// The last modification date of the assembly.
		/// </summary>
		private DateTime? LastMod = null ;

		/// <summary>
		/// The available resources.
		/// </summary>
		private Dictionary<string, Resource> ResourceNames = null ;
		#endregion

		/// <summary>
		/// Handles the current request.
		/// </summary>
		/// <param name="context">The current http context</param>
		/// <param name="args">the url data arguments</param>
		public void HandleRequest(HttpContext context, params string[] args) {
			var resource = args.Implode(".").ToLower() ;
			var assembly = Assembly.GetExecutingAssembly() ;

			if (!LastMod.HasValue)
				GetLastMod(assembly) ;

			if (!Web.ClientCache.HandleClientCache(context, resource, LastMod.Value)) {
				if (ResourceNames == null)
					GetResourceNames(assembly) ;
				if (ResourceNames.ContainsKey(resource)) {
					var res = ResourceNames[resource] ;

					using (var stream = assembly.GetManifestResourceStream(res.Name)) {
						var bytes = new byte[stream.Length] ;
						stream.Read(bytes, 0, Convert.ToInt32(stream.Length)) ;

						context.Response.ContentType = res.ContentType ;
						context.Response.BinaryWrite(bytes) ;
						context.Response.StatusCode = 200 ;
						context.Response.End() ;
					}
				} else {
					context.Response.StatusCode = 404 ;
				}
			}
		}

		#region Private methods
		/// <summary>
		/// Gets the last modification date from the assembly.
		/// </summary>
		/// <param name="assembly">The assembly</param>
		private void GetLastMod(Assembly assembly) {
			LastMod = new FileInfo(assembly.Location).LastWriteTime ;
		}

		/// <summary>
		/// Gets the currently available resources from the assembly.
		/// </summary>
		/// <param name="assembly">The assembly</param>
		private void GetResourceNames(Assembly assembly) {
			ResourceNames = new Dictionary<string, Resource>() ;

			foreach (var name in assembly.GetManifestResourceNames()) {
				ResourceNames.Add(name.Replace("Piranha.", "").ToLower(), new Resource() {
					Name = name, ContentType = GetContentType(name)
				}) ;
			}
		}

		/// <summary>
		/// Gets the content type from the resource name.
		/// </summary>
		/// <param name="name">The resource name</param>
		/// <returns>The content type</returns>
		private string GetContentType(string name) {
			if (name.EndsWith(".js")) {
				return "text/javascript" ;
			} else if (name.EndsWith(".css")) {
				return "text/css" ;
			} else if (name.EndsWith(".png")) {
				return "image/png" ;
			} else if (name.EndsWith(".jpg")) {
				return "image/jpg" ;
			} else if (name.EndsWith(".gif")) {
				return "image/gif" ;
			} else if (name.EndsWith(".ico")) {
				return "image/ico" ;
			} else if (name.EndsWith(".eot")) {
				return "application/vnd.ms-fontobject" ;
			} else if (name.EndsWith(".ttf")) {
				return "application/octet-stream" ;
			} else if (name.EndsWith(".svg")) {
				return "image/svg+xml" ;
			} else if (name.EndsWith(".woff")) {
				return "application/x-woff" ;
			}
			return "application/unknown" ;
		}
		#endregion
	}
}